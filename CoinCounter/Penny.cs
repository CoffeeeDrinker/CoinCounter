using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCounter
{
    internal class Penny : Coin
    {
        public Penny(int amount) : base(0.01m, amount)
        {

        }
        override
        public decimal GetValue()
        {
            return Value * Count;
        }
    }
}
