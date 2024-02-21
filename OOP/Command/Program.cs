namespace Command
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            TransactionManager transactionManager = new TransactionManager();
            Account account = new Account("John Doe", 0);
            Deposit deposit = new Deposit(account, 100);
            transactionManager.AddTransaction(deposit);
            Console.WriteLine("Pending: " + transactionManager.HasPendingTransactions);
            Console.WriteLine(account.Balance);
            transactionManager.ProcessPendingTransactions();
            Console.WriteLine("Pending: " + transactionManager.HasPendingTransactions);
            Console.WriteLine(account.Balance);
            Withdraw withdrawal = new Withdraw(account, 50);
            transactionManager.AddTransaction(withdrawal);
            transactionManager.ProcessPendingTransactions();
            Console.WriteLine("Pending: " + transactionManager.HasPendingTransactions);
            Console.WriteLine(account.Balance);

        }
    }
}



