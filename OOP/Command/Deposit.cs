using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Deposit : ITransaction
    {
        private readonly Account account;
        private readonly decimal amount;
        public bool IsCompleted { get; set; }
        public Deposit(Account account, decimal amount)
        {
            this.account = account;
            this.amount = amount;
            IsCompleted = false;
        }
        public void Execute()
        {
            account.Balance += amount;
            IsCompleted = true;
        }
    }
}
