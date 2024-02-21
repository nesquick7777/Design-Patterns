using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class TransactionManager
    {
        private readonly List<ITransaction> transactions = new List<ITransaction>();
        public bool HasPendingTransactions
        {
            get { return transactions.Any(t => !t.IsCompleted); }
        }
        public void AddTransaction(ITransaction transaction)
        {
            transactions.Add(transaction);
        }
        public void ProcessPendingTransactions()
        {
            foreach (ITransaction transaction in transactions.Where(t => !t.IsCompleted))
            {
                transaction.Execute();
            }
        }
    }
}
