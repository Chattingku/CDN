using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ChattingKu.CDN.Models
{
    public class LoginModel
    {
        [Required]
        public string Name { get; set; }
    }
}