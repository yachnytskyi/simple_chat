﻿using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;

namespace simple_chat
{
    public class CustomUserIdProvider : IUserIdProvider
    {
        public virtual string GetUserId(HubConnectionContext connection)
        {
            return connection.User?.Identity.Name;
        }
    }
}
