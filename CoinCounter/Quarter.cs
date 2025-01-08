using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCounter
{
    internal class Quarter : Coin
    {
        public Quarter(int amount) : base(0.25m, amount)
        {

        }

        override
        public decimal GetValue()
        {
            return Value * Count;
        }
    }
}
