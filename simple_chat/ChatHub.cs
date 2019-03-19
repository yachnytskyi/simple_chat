using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace simple_chat
{
    public class ChatHub : Hub
    {
        public async Task Send(List<string> items)
        {
            await Clients.Caller.SendAsync("Receive", items);
        }
    }
}