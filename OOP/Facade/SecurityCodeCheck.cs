using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class SecurityCodeCheck
    {
        private int securityCode = 1234;

        public int getSecurityCode()
        {
            return securityCode;
        }



        public Boolean isCodeCorrect(int secCodeToCheck)
        {
            if (secCodeToCheck == getSecurityCode())
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
