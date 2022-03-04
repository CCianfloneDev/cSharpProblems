using System;
using System.Collections.Generic;

namespace ColesStopAndShop
{
    /// <summary>
    /// Represents a gas station of franchise Cole's Stop And Shop
    /// </summary>
    public class GasStation
    {
        private int numberOfGasPumps;
        private int storeId;
        private int numberOfEmployees;
        private decimal fuelCapacity;
        private Dictionary<int, bool> fuelPumps;

        /// <summary>
        /// Gets address of gas station.
        /// </summary>
        public string Address
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets number of pumps at gas station.
        /// </summary>
        public int NumberOfGasPumps
        {
            get
            {
                return this.numberOfGasPumps;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Argument cannot be less than zero.");
                }

                this.numberOfGasPumps = value;
            }
        }

        /// <summary>
        /// Gets store id associated with gas station.
        /// </summary>
        public int StoreId
        {
            get
            {
                return this.storeId;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Argument cannot be less than zero.");
                }

                this.storeId = value;
            }
        }

        /// <summary>
        /// Gets number of employees working for gas station.
        /// </summary>
        public int NumberOfEmployees
        {
            get
            {
                return this.numberOfEmployees;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Argument cannot be less than zero.");
                }

                this.numberOfEmployees = value;
            }
        }

        /// <summary>
        /// Gets whether it serves hot food or not.
        /// </summary>
        public bool ServesHotFood
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets whether it's a rest stop or not.
        /// </summary>
        public bool IsRestStop
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets list of all items with respective prices at store.
        /// </summary>
        public IDictionary<ItemId, decimal> AllItemsAtStore
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets and sets fuel capacity of storage tanks, in liters.
        /// </summary>
        public decimal FuelCapacity
        {
            get
            {
                return this.fuelCapacity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Argument cannot be less than zero.");
                }
                
                this.fuelCapacity = value;
            }
        }

        /// <summary>
        /// Gets and sets fuel pumps at gas station.
        /// </summary>
        public Dictionary<int, bool> FuelPumps
        {
            get
            {
                return this.fuelPumps;
            }
            set 
            { 
                this.fuelPumps = value;
            }
        }
        /// <summary>
        /// Initializes a gas station with a given address, number of gas pumps, store ID, number of employees, whether it serves hot food or not, and whether it is a rest stop or not.
        /// </summary>
        /// <param name="address">Address of gas station.</param>
        /// <param name="numberOfGasPumps">Number of pumps at gas station.</param>
        /// <param name="storeId">ID associated with gas station.</param>
        /// <param name="numberOfEmployees">Number of employees working for gas station.</param>
        /// <param name="servesHotFood">Has hot food or not.</param>
        /// <param name="isRestStop">Is a rest stop or not.</param>
        /// <param name="allItemsAtStore">All items for sale at this store.</param>
        public GasStation(string address, int numberOfGasPumps, int storeId, int numberOfEmployees, bool servesHotFood, bool isRestStop, IDictionary<ItemId, decimal> allItemsAtStore, decimal fuelCapacity, Dictionary<int, bool> fuelPumps)
        {
            if (address == null)
            {
                throw new ArgumentNullException("address", "Gas station cannot be instantiated without an address.");
            }
            if (numberOfGasPumps < 0)
            {
                throw new ArgumentOutOfRangeException("numberOfGasPumps", "Cannot have negative gas pumps.");
            }
            if (storeId < 0)
            {
                throw new ArgumentOutOfRangeException("storeId", "Gas station cannot be instantiated with negative store Id.");
            }
            if (numberOfEmployees <= 0)
            {
                throw new ArgumentOutOfRangeException("numberOfEmployees", "Cannot open gas station with zero or negative employees.");
            }
            if (fuelCapacity < 0)
            {
                throw new ArgumentOutOfRangeException("fuelCapacity", "Cannot open gas station with negative fuel capacity.");
            }
            if (fuelPumps.Count < 0)
            {
                throw new ArgumentOutOfRangeException("fuelPumps.key", "Cannot have negative fuel pumps.");
            }

            Address = address;
            NumberOfGasPumps = numberOfGasPumps;
            StoreId = storeId;
            NumberOfEmployees = numberOfEmployees;
            ServesHotFood = servesHotFood;
            IsRestStop = isRestStop;
            AllItemsAtStore = allItemsAtStore;
            FuelCapacity = fuelCapacity;
            
        }

        /// <summary>
        /// Returns a string representation of the gas station.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Gas station:" +
                   $"Address: {Address}\n" +
                   $"Number of gas pumps: {NumberOfGasPumps}\n" +
                   $"Store ID: {StoreId}\n" +
                   $"Number of employees: {NumberOfEmployees}\n" +
                   $"Has hot food?: {ServesHotFood}\n" +
                   $"Is a rest stop?: {IsRestStop}\n";
        }
    }
}
