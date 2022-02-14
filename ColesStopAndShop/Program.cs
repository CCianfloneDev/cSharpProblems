using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColesStopAndShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ItemId> items = new List<ItemId>();
            items.Add((ItemId)1000);

            CashRegister cashRegister = new CashRegister(0, 0, 42069);

            cashRegister.ProcessPayment(true);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
