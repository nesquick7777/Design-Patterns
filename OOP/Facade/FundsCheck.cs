using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class FundsCheck
    {
        private double cashInAccount = 1000.00;

        public double getCashInAccount()
        {
            return cashInAccount;
        }

        public void decreaseCashInAccount(double cashWithdrawn)
        {
            cashInAccount -= cashWithdrawn;
        }

        public void increaseCashInAccount(double cashDeposited)
        {
            cashInAccount += cashDeposited;
        }

        public Boolean haveEnoughMoney(double cashToWithdraw)
        {
            if (cashToWithdraw > cashInAccount) {
                Console.WriteLine("You dont have enough money");
                Console.WriteLine("Current balance" + cashInAccount);
                return false;
                
            }
            else
            {
                decreaseCashInAccount(cashToWithdraw);
                Console.WriteLine("Withdraw complete");
                Console.WriteLine("Current balance " + cashInAccount);
                return true;
            }
        }

        public void makeDeposit(double cashToDeposit) {

            increaseCashInAccount(cashToDeposit);
            Console.WriteLine("Deposit Complete: Cash Balance is " + cashInAccount);

        }

    }
}
