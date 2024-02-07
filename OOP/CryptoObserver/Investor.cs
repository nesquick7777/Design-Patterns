using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoObserver
{
    internal class Investor : IInvestor
    {
        private string Name { get; set; }
        private CryptoCoin coin;

        public Investor(string name) { this.Name = name; }

        public void Update(CryptoCoin stock)
        {
            Console.WriteLine("Notified: " + this.Name + " of "+ stock.Type+ " price change to " + stock.Price);
        }

        public CryptoCoin Stock { get { return coin; } set { coin = value; } }
    }
}
