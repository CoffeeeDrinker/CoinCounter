using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCounter
{
    internal class CoinJar
    {
        private List<Coin> coins;
        public CoinJar()
        {
            coins = new List<Coin>();
        }

        public void AddCoin(Coin coin)
        {
            coins.Add(coin);
        }

        public decimal GetValue()
        {
            decimal total = 0;

            foreach(Coin coin in coins)
            {
                total += coin.GetValue();
            }

            return total;
        }
    }
}
