using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatAppDTO;
using ChatSignalR.Models;
using Microsoft.AspNetCore.SignalR;

namespace ChatSignalR.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(ChatMessage message)
        {
            Clients.All.SendAsync("ReceivedMessage", message);
        }

        public void SignInUser(string userName)
        {
            Clients.All.SendAsync("UserSignedIn", userName);
        }
    }
}
