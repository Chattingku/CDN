using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChattingKu.CDN.Models
{
    public class Chat
    {
        public string UserName { get; set; }
        public string Message { get; set; }
        public string Date { get; set; }

        public Chat(string username, string message, string date)
        {
            this.UserName = username;
            this.Message = message;
            this.Date = date;
        }
    }
}