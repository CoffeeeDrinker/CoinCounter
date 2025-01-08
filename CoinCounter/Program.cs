using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoinJar jar = new CoinJar();

            while(true)
            {
                PrintCoinList();
                FindValidOption(out int option);
                FindValidAmount(out int amount);

                if(amount == 0)
                {
                    continue;
                }

                switch(option)
                {
                    case 1:
                        jar.AddCoin(new Penny(amount));
                        break;
                    case 2:
                        jar.AddCoin(new Nickel(amount));
                        break;
                    case 3:
                        jar.AddCoin(new Dime(amount));
                        break;
                    case 4:
                        jar.AddCoin(new Quarter(amount));
                        break;
                    default:
                        Console.WriteLine("Error: Invalid Option");
                        break;
                }

                Console.WriteLine($"Total: {jar.GetValue():c}");
            }
        }
        static void PrintCoinList()
        {
            Console.WriteLine("1: Penny ($0.01)");
            Console.WriteLine("2: Nickel ($0.05)");
            Console.WriteLine("3: Dime ($0.10)");
            Console.WriteLine("4: Quarter ($0.25)");
        }

        static void FindValidOption(out int option)
        {
            while(true)
            {
                Console.WriteLine("What type of coin do you want to add?");
                if(int.TryParse(Console.ReadLine(), out option) && option >= 1 && option <= 4)
                {
                    break;
                }
                Console.WriteLine("Please choose a valid integer between 1 and 4");
            }
        }

        static void FindValidAmount(out int amount)
        {
            while(true)
            {
                Console.WriteLine("How many coins do you want to add?");
                if(int.TryParse(Console.ReadLine(), out amount) && amount >= 0)
                {
                    break;
                }
                Console.WriteLine("Please choose a valid integer greater than or equal to 0");
            }
        }
    }
}
