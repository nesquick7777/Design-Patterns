using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class BankAccountFacade
    {
        private int accountNumber;
        private int securityCode;

        AccountNumberCheck acctCheck;
        SecurityCodeCheck codeChecker;
        FundsCheck fundChecker;
        WelcomeToBank welcome;

        public BankAccountFacade(int newAcctNum, int newSecCode)
        {
            accountNumber = newAcctNum;
            securityCode = newSecCode;
            acctCheck = new AccountNumberCheck();
            codeChecker = new SecurityCodeCheck();
            fundChecker = new FundsCheck();
            welcome = new WelcomeToBank();
        }

        public int getAccountNumber() { return accountNumber; }
        public int getSecurityCode() {  return securityCode; }

        public void withdrawCash(double cashToGet)
        {
            if (acctCheck.accountActive(getAccountNumber()) && 
                codeChecker.isCodeCorrect(getSecurityCode()) && 
                fundChecker.haveEnoughMoney(cashToGet))

            {
                Console.WriteLine("Transaction Complete\n");
            }
            else
            {
                Console.WriteLine("Transaction Failed\n");
            }
        }

        public void depositCash(double cashToDeposit)
        {
            if (acctCheck.accountActive(getAccountNumber()) &&
                codeChecker.isCodeCorrect(getSecurityCode()))

            {
                Console.WriteLine("Transaction Complete\n");
                fundChecker.makeDeposit(cashToDeposit);
            }
            else
            {
                Console.WriteLine("Transaction Failed\n");
            }
        }
    }
}
