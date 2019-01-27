using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp4Lib;


namespace MyApp4Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            VisibleBotMethods vbm = new VisibleBotMethods();
            String UsdPrice = vbm.GetPriceOfBitcoin("usd");
            String EurPrice = vbm.GetPriceOfBitcoin("eur");
            Console.WriteLine("\nPrice of Bitcoin in USD: " + UsdPrice);
            Console.WriteLine("\nPrice of Bitcoin in EUR: " + EurPrice);
            Console.ReadKey();

        }
    }
}
