using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCounter
{
    internal class Nickel : Coin
    {
        public Nickel(int amount) : base(0.05m, amount)
        {

        }

        override
        public decimal GetValue()
        {
            return Value * Count;
        }
    }
}
