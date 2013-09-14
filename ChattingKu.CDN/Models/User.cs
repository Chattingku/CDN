using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChattingKu.CDN.Models
{
    public class User
    {
        public string Name { get; set; }
        public HashSet<string> ConnectionIds { get; set; }
    }
}