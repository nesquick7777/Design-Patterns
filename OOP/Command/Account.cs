using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Account
    {
        public String OwnerName { get; set; }
        public decimal Balance { get; set; }
        public Account(String ownerName, decimal balance)
        {
            this.OwnerName = ownerName;
            this.Balance = balance;
        }

    }
}
