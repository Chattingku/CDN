using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
using ChattingKu.CDN.Models;

namespace ChattingKu.CDN.Hubs
{
    [HubName("chattingKu")]
    public class ChattingHub : Hub
    {
        public Task registerHub(string accountId, string username)
        {
            return Groups.Add(Context.ConnectionId, accountId).ContinueWith(a =>
            {
                SendGreeting(accountId, username);
            });
        }

        public Task SendGreeting(string accountId, string username)
        {
            Account acc = accounts.FirstOrDefault(test => test.Id == accountId);
            Chat chat = new Chat(acc.Name, WelcomeMessage.Default(username), "");
            return Clients.Group(accountId, "").newMessage(chat);
        }

        public Task Send(string accountId, string username, string message, string date)
        {
            Chat chat = new Chat(username, message, date);
            return Clients.Group(accountId, Context.ConnectionId).newMessage(chat);
        }

        private List<Account> accounts = new List<Account>();
        public ChattingHub()
        {
            accounts.Add(new Account { Id = "3236802", Name = "LENOVO" });
        }
    }
}