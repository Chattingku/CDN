using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace ChattingKu.Hubs
{
    [HubName("chattingKu")]
    public class ChattingHub : Hub
    {
        public Task registerHub(string accountId)
        {
            return Groups.Add(Context.ConnectionId, accountId);
        }

        public Task Send(string accountId, string message)
        {
            return Clients.Group(accountId, "").newMessage(message);
        }
    }
}