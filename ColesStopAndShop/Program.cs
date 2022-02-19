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
            // Console.Beep(18000, 1000);
            // This is all the items that gasStation01 will keep in inventory.
            Dictionary<ItemId, decimal> allItemsAtStore = new Dictionary<ItemId, decimal>
            {
                { ItemId.Slurpee, 2.15m },
                { ItemId.Apple, 1.15m },
                { ItemId.Taquito, 2.75m },
                { ItemId.Gatorade, 3.75m },
                { ItemId.Banana, 2.25m },
                { ItemId.HoneyBuns, 2.35m },
                { ItemId.Crackers, 1.75m }
            };


            GasStation gasStation01 = new GasStation("109 Asdora", 2, 232, 2, true, false, allItemsAtStore);
            CashRegister cashRegister = new CashRegister(0, 0, 0, gasStation01, 0.07m, 0.14m);

            cashRegister.ProcessPayment(PaymentType.Debit);

            Console.WriteLine(cashRegister.DebitBalance);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
