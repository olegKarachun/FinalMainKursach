using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class CommentHub : Hub
    {
        public async Task AddToStory(string Name)
        {            
            await Groups.AddToGroupAsync(Context.ConnectionId, Name);
        }
        public async Task Send(string comment, string storyId, string Email)
        {            
            await Clients.Group(storyId).SendAsync("updatecomments", comment, Email);
        }
    }
}
