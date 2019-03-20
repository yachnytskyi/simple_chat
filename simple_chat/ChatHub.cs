using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace simple_chat
{
    [Authorize]
    public class ChatHub : Hub
    {
        public async Task Send(string message, string to)
        {
            var userName = Context.User.Identity.Name;

            if (Context.UserIdentifier!=to) // if the recipient and the current user do not match
            {
                await Clients.User(Context.UserIdentifier).SendAsync("Receive", message, userName);
            }

            await Clients.User(Context.UserIdentifier).SendAsync("Receive", message, userName);
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("Notify", $"Hello {Context.UserIdentifier}");
            await base.OnConnectedAsync();
        }
    }
}