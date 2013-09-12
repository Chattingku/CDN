using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChattingKu.CDN.Models
{
    public static class WelcomeMessage
    {
        public static string Default(string username)
        {
            return string.Format("Selamat datang {0}, apa yang bisa kami bantu ?", username);
        }
    }
}