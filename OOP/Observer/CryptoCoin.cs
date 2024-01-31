using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal abstract class CryptoCoin
    {
        public String Type { get; set; }
        private double price;
        public List<Investor> investors;

        public CryptoCoin(string type, double price) {
            this.Type = type;
            this.price = price;
            this.investors = new List<Investor>();
        }

        public void Attach(Investor investor) { investors.Add(investor); }
        public void Detach(Investor investor) { investors.Remove(investor); }
        public void Notify()
        {
            foreach (IInvestor investor in investors)
            {
                investor.Update(this);
            }
        }

        public double Price { 
            get { return price; } set { if (price != value) { price = value; Notify(); } } 
        }
    }
}
