using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCounter
{
    internal abstract class Coin
    {
        private decimal value;
        private int count;
        public decimal Value { get { return value; } set { this.value = value; } }
        public int Count { get { return count; } set { count = value; } }

        public Coin(decimal value, int count)
        {
            this.count = count;
            this.value = value;
        }
        public abstract decimal GetValue();
    }
}
