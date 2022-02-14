namespace ColesStopAndShop
{
    /// <summary>
    /// Represents a gas station of franchise Cole's Stop And Shop
    /// </summary>
    public class GasStation
    {
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
            get;
            private set;
        }

        /// <summary>
        /// Gets store id associated with gas station.
        /// </summary>
        public int StoreId
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets number of employees working for gas station.
        /// </summary>
        public int NumberOfEmployees
        {
            get;
            set;
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
        /// Initializes a gas station with a given address, number of gas pumps, store ID, number of employees, whether it serves hot food or not, and whether it is a rest stop or not.
        /// </summary>
        /// <param name="address">Address of gas station.</param>
        /// <param name="numberOfGasPumps">Number of pumps at gas station.</param>
        /// <param name="storeId">ID associated with gas station.</param>
        /// <param name="numberOfEmployees">Number of employees working for gas station.</param>
        /// <param name="servesHotFood">Has hot food or not.</param>
        /// <param name="isRestStop">Is a rest stop or not.</param>
        public GasStation(string address, int numberOfGasPumps, int storeId, int numberOfEmployees, bool servesHotFood, bool isRestStop)
        {
            Address = address;
            NumberOfGasPumps = numberOfGasPumps;
            StoreId = storeId;
            NumberOfEmployees = numberOfEmployees;
            ServesHotFood = servesHotFood;
            IsRestStop = isRestStop;
        }

        /// <summary>
        /// Returns a string representation of the gas station.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Gas station:" +
                   $"\n Address: {Address}" +
                   $"\n Number of gas pumps: {NumberOfGasPumps}" +
                   $"\n Store ID: {StoreId}" +
                   $"\n Number of employees: {NumberOfEmployees}" +
                   $"\n Has hot food?: {ServesHotFood}" +
                   $"\n Is a rest stop?: {IsRestStop}";
        }
    }
}
