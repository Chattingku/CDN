using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChattingKu.CDN.Models;
using System.Collections.Concurrent;

namespace ChattingKu.CDN.FakeRepository
{
    public class FakeConnectionRepository
    {
        private static readonly ConcurrentDictionary<string, User> Users = new ConcurrentDictionary<string, User>();
    }
}