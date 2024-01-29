using Facade;

namespace Prototype
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            BankAccountFacade accessingBank = new BankAccountFacade(12345678,1234);

            accessingBank.withdrawCash(50.00);
            accessingBank.withdrawCash(900.00);
            accessingBank.depositCash(200);
        }
    }
}