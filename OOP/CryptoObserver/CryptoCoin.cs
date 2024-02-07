using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoObserver
{
    internal abstract class CryptoCoin
    {
        public string Type { get; private set; }
        private List<IInvestor> investors;
        private double price;

        public CryptoCoin(string type, double price)
        {
            Type = type;
            this.investors = new List<IInvestor>();
            Price = price;
        }

        public void Attach(IInvestor investor) { investors.Add(investor); }

        public void Detach(IInvestor investor) { investors.Remove(investor); }

        public double Price
        {
            get { return price; }
            set { if (price != value) { price = value; Notify(); } }
        }

        public void Notify()
        {
            foreach(IInvestor investor in investors) { investor.Update(this); };
        }
    }
}
