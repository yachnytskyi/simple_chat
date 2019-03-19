using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace simple_chat
{
    public class ChatHub : Hub
    {
        public async Task Send(string message)
        {
            await Clients.All.SendAsync("Receive", message, Context.ConnectionId);
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("Notify", $"{Context.ConnectionId} entered chat");
            await base.OnConnectedAsync();
        }
        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Clients.All.SendAsync("Notify", $"{Context.ConnectionId} left chat chat");
            await base.OnDisconnectedAsync(exception);
        }
    }
}