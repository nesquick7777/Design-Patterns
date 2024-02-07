using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoObserver
{
    internal class BitCoin : CryptoCoin
    {
        public BitCoin(string type, double price) : base(type, price)
        {
        }
    }
}
