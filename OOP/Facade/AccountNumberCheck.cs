using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class AccountNumberCheck
    {
        private int accountNumber = 12345678;
        public int getAccountNumber()
        {
            return accountNumber;
        }

        public Boolean accountActive(int accNumToCheck)
        {
            if(accNumToCheck == getAccountNumber())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
