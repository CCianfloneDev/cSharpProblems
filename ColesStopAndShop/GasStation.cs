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
        /// Gets the cash balance of a cash register.
        /// </summary>
        public decimal CashBalance
        {
            get
            {
                return cashBalance;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Argument cannot be less than zero.");
                }
                cashBalance = value;
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
        /// <param name="cashBalance">Cash balance.</param>
        /// <param name="storeDeployedAt">Gas station in which it's deployed.</param>
        /// <param name="gstRate">Federal sales tax rate.</param>
        /// <param name="pstRate">Provincial sales tax rate.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when credit balance, debit balance or cash balance is less than zero.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when store associated to isn't of valid reference type.
        /// </exception>
        public CashRegister(decimal creditBalance, decimal debitBalance, decimal cashBalance, GasStation storeDeployedAt, decimal pstRate, decimal gstRate)
        {
            if (creditBalance < 0)
            {
                throw new ArgumentOutOfRangeException("creditBalance", "Credit balance cannot be less than zero.");
            }
            if (debitBalance < 0)
            {
                throw new ArgumentOutOfRangeException("debitBalance", "Debit balance cannot be less than zero.");
            }
            if (cashBalance < 0)
            {
                throw new ArgumentOutOfRangeException("debitBalance", "Debit balance cannot be less than zero.");
            }
            if (storeDeployedAt.GetType() != typeof(GasStation))
            {
                throw new ArgumentException("storeDeployedAt", "Must be of type gas station.");
            }

            CreditBalance = creditBalance;
            DebitBalance = debitBalance;
            CashBalance = cashBalance;
            StoreDeployedAt = storeDeployedAt;
            PstRate = pstRate;
            GstRate = gstRate;
        }

        /// <summary>
        /// Processes payment with given fact that it is debit/cash or credit.
        /// </summary>
        /// <param name="paymentChosen">The payment type chosen by customer.</param>
        public void ProcessPayment(PaymentType paymentChosen)
        {
            decimal salesTaxCharged = 0;
            decimal total = 0;
            decimal subTotal = 0;
            
            List<ItemId> listOfItems = new List<ItemId>();

            // Scans each item given to clerk. 
            do
            {
                Console.Clear();

                Console.WriteLine("Are you getting fuel today? (yes/no)");

                if ((string)Console.ReadLine().ToLower() == "no")
                {
                    continue;
                }
                else if((string)Console.ReadLine().ToLower() == "yes")
                {
                    Console.WriteLine("Which pump are you at?");
                    // I need to impl. a Dict for gas stations; Dict<int(pumpNum), bool(isPumping)>
                }

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
                    // This loop checks to verify the key exists in the pre-defined dictionary before adding it.
                    // No error message is thrown if non existent and nothing is added to list, just moves on to next item.
                    foreach (ItemId itemId in storeDeployedAt.AllItemsAtStore.Keys)
                    {
                        if ((ItemId)itemScanned == itemId)
                        {
                            listOfItems.Add((ItemId)itemScanned);
                            break;
                        }
                    }
                }

            } while (true);

            // After items are scanned; affect till balance and get total cost.
            foreach (ItemId itemBought in listOfItems)
            {
                decimal pricePerItem = storeDeployedAt.AllItemsAtStore[itemBought];
                subTotal += pricePerItem;

                if (paymentChosen == PaymentType.Credit)
                {
                    CreditBalance += pricePerItem;
                }
                else if (paymentChosen == PaymentType.Debit)
                {
                    DebitBalance += pricePerItem;
                }
                else if (paymentChosen == PaymentType.Cash)
                {
                    CashBalance += pricePerItem;
                }
            }
            // Calculated for purpose of showing tax difference on receipt
            decimal pstCharged = subTotal * PstRate;
            decimal gstCharged = subTotal * GstRate;

            salesTaxCharged = subTotal * SalesTaxRate;
            total = subTotal + salesTaxCharged;

            /*
             * Prints Receipt below 
             */
            Console.Clear();
            Console.WriteLine($"Thanks for stopin' and shopin' at Cole's Stop and Shop!\n");

            Console.WriteLine(" Here's your receipt.\n");

            foreach (ItemId itemBought in listOfItems)
            { 
                Console.WriteLine($" {itemBought.ToString()} : ${storeDeployedAt.AllItemsAtStore[itemBought]}");
            }
            Console.WriteLine($" Sub total: ${subTotal}");
            Console.WriteLine($" Tax charged: ${decimal.Round(salesTaxCharged, 2)}");
            Console.WriteLine($"  PST charged: ${decimal.Round(pstCharged, 2)}");
            Console.WriteLine($"  GST charged: ${decimal.Round(gstCharged, 2)}");
            Console.WriteLine($" Total cost: ${decimal.Round(total,2)}");
            Console.WriteLine($" Items paid for using: {paymentChosen.ToString()}");
            Console.WriteLine($" Purchase processed at: {DateTime.Now.ToString()}\n");
        }
    }
}
