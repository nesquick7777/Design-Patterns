using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Withdraw :ITransaction
    {
        private readonly Account account;
        private readonly decimal amount;
        public bool IsCompleted { get; set; }
        public Withdraw(Account account, decimal amount)
        {
            this.account = account;
            this.amount = amount;
            IsCompleted = false;
        }
        public void Execute()
        {
            if (account.Balance >= amount)
            {
                account.Balance -= amount;
                IsCompleted = true;
            }
        }
    }
}
