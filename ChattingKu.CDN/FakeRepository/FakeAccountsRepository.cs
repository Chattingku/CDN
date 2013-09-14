using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChattingKu.CDN.Models;

namespace ChattingKu.CDN.FakeRepository
{
    public class FakeAccountsRepository
    {
        public List<Account> Account { get; private set; }
        public FakeAccountsRepository()
        {
            Account.Add(new Account
            {
                Id = "123456",
                Name = "Denny Wu"
            });

            Account.Add(new Account
            {
                Id = "654321",
                Name = "Apin Wu"
            });
        }
    }
}