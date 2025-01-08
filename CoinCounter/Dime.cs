using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCounter
{
    internal class Dime : Coin
    {
        public Dime(int amount) : base(0.10m, amount)
        {

        }

        override
        public decimal GetValue()
        {
            return Count * Value;
        }
    }
}
