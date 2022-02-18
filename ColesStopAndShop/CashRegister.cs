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
        private decimal pstRate;
        private decimal gstRate;
        private GasStation storeDeployedAt;

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
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Argument cannot be less than zero.");
                }
                debitBalance = value;
            }
        }

        /// <summary>
        /// Gets combined sales tax rate of PST and GST.
        /// </summary>
        public decimal SalesTaxRate
        {
            get
            {
                return PstRate + GstRate;
            }
        }

        /// <summary>
        /// Gets PstRate associated with cash register. (Determined by provincial government.)
        /// </summary>
        public decimal PstRate
        {
            get
            {
                return this.pstRate;
            }
            private set
            {
                this.pstRate = value;
            }
        }

        /// <summary>
        /// Gets GstRate associated with cash register. (Determined by federal government.)
        /// </summary>
        public decimal GstRate
        {
            get
            {
                return this.gstRate;
            }
            private set
            {
                this.gstRate = value;
            }
        }

        /// <summary>
        /// Gets the store this cash register is deployed at.
        /// </summary>
        public GasStation StoreDeployedAt
        {
            get
            {
                return this.storeDeployedAt;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Must assign this cash register to a store.");
                }
                if (value.GetType() != typeof(GasStation))
                {
                    throw new ArgumentException("Must be of type Gas Station.");
                }
                
                this.storeDeployedAt = value;
            }
        }

        /// <summary>
        /// Initializes a cash register with a given credit balance, given debit balance, and ID number of associated store.
        /// </summary>
        /// <param name="creditBalance">Credit balance.</param>
        /// <param name="debitBalance">Debit balance.</param>
        /// <param name="storeDeployedAt">Gas station in which it's deployed.</param>
        /// <param name="gstRate">Federal sales tax rate.</param>
        /// <param name="pstRate">Provincial sales tax rate.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when credit balance or debit balance is less than zero.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when store associated to isn't of valid reference type.
        /// </exception>
        public CashRegister(decimal creditBalance, decimal debitBalance, GasStation storeDeployedAt, decimal pstRate, decimal gstRate)
        {
            if (creditBalance < 0)
            {
                throw new ArgumentOutOfRangeException("creditBalance", "Credit balance cannot be less than zero.");
            }
            if (debitBalance < 0)
            {
                throw new ArgumentOutOfRangeException("debitBalance", "Debit balance cannot be less than zero.");
            }
            if (storeDeployedAt.GetType() != typeof(GasStation))
            {
                throw new ArgumentException("storeDeployedAt", "Must be of type gas station.");
            }

            CreditBalance = creditBalance;
            DebitBalance = debitBalance;
            StoreDeployedAt = storeDeployedAt;
            PstRate = pstRate;
            GstRate = gstRate;
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

            totalCostOfPurchase *= SalesTaxRate;

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
