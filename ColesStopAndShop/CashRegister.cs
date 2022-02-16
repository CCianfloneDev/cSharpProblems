using System;
using System.Collections.Generic;

namespace ColesStopAndShop
{
    /// <summary>
    /// Represents a cash register inside of a gas station of Cole's-Stop-And-Shop-franchise.
    /// </summary>
    public class CashRegister
    {
        private decimal creditBalance;
        private decimal debitBalance;
        private decimal cashBalance;
        private decimal salesTaxRate;
        private int storeId;

        /// <summary>
        /// Gets the credit balance of a cash register, balance will be positive.
        /// </summary>
        public decimal CreditBalance
        {
            get
            {
                return creditBalance;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Argument cannot be less than zero.");
                }
                creditBalance = value;
            }
        }

        /// <summary>
        /// Gets the debit balance of a cash register.
        /// </summary>
        public decimal DebitBalance
        {
            get
            {
                return debitBalance;
            }

            private set
            {
                debitBalance = value;
            }
        }

        /// <summary>
        /// Gets sales tax rate.
        /// </summary>
        public decimal SalesTaxRate
        {
            get
            {
                return salesTaxRate;
            }
            private set
            {
                salesTaxRate = value;
            }
        }
        /// <summary>
        /// Gets the store ID.
        /// </summary>
        public int StoreId
        {
            get
            {
                return storeId;
            }

            private set
            {
                storeId = value;
            }
        }

        /// <summary>
        /// Initializes a cash register with a given credit balance, given debit balance, and ID number of associated store.
        /// </summary>
        /// <param name="creditBalance">Credit balance.</param>
        /// <param name="debitBalance">Debit balance.</param>
        /// <param name="storeId">Store ID.</param>
        public CashRegister(decimal creditBalance, decimal debitBalance, int storeId)
        {
            CreditBalance = creditBalance;
            DebitBalance = debitBalance;
            StoreId = storeId;
        }

        /// <summary>
        /// Processes payment with given fact that it is debit/cash or credit.
        /// </summary>
        /// <param name="isDebitOrCash">The fact that it is debit/cash or credit.</param>
        public void ProcessPayment(bool isDebitOrCash)
        {
            decimal totalCostOfPurchase = 0;
            List<int> listOfItemPricesAtPurchase = new List<int>();
            List<ItemId> listOfItems = new List<ItemId>();

            // Scans each item given to clerk. 
            do
            {
                //Console.Clear();
                Console.WriteLine("Key (9) to process payment.");

                Console.WriteLine("Enter item id: ");
                int.TryParse(Console.ReadLine(), out int itemScanned);

                if (itemScanned == 9)
                {
                    break;
                }

                if (!Enum.IsDefined(typeof(ItemId), itemScanned))
                {
                    Console.WriteLine("Invalid item id.");
                    Console.WriteLine("Press any key to retry...");
                    Console.ReadKey();
                    continue;
                }
                else
                {
                    listOfItems.Add((ItemId)itemScanned);

                    Console.WriteLine("Enter cost of item: ");
                    int priceOfItem = int.Parse(Console.ReadLine());

                    listOfItemPricesAtPurchase.Add(priceOfItem);
                }

            } while (true);

            // After items are scanned; affect till balance and get total cost.
            foreach(int itemPrice in listOfItemPricesAtPurchase)
            {
                totalCostOfPurchase += itemPrice;

                if (!isDebitOrCash)
                {
                    CreditBalance += itemPrice;
                }
                else
                {
                    DebitBalance += itemPrice;
                }
            }

            totalCostOfPurchase *= salesTaxRate;

            // Converts items to string for receipt.
            List<string> itemsBoughtToString = new List<string>();
            foreach (ItemId item in listOfItems)
            {
                itemsBoughtToString.Add(item.ToString());
            }

            /*
             * Prints Receipt below 
             */

            Console.WriteLine($"Thanks for stopin' and shopin' at Cole's Stop and Shop!");

            Console.WriteLine("Items: ");

            for (int i = 0; i < listOfItems.Count; i++)
            {
                for (int j = 0; j < listOfItems.Count; j++)
                {
                    Console.WriteLine($" {listOfItemPricesAtPurchase[i]} :  {itemsBoughtToString[i]}");
                }
            }

            Console.WriteLine($"\n Items paid for using {(isDebitOrCash ? "Debit/Cash" : "Credit")}");

        }
    }
}
