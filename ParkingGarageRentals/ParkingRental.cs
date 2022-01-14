/* Author: Cole Cianflone
 * Date: Jan 13th, 2022
 */
namespace ParkingSystem
{
    /// <summary>
    /// Represents a spot in parking garage.
    /// </summary>
    class ParkingRental
    {
        private int maxParkingSpots;
        private int remainingParkingSpots;
        private ParkingPass passChosen;
        
        /// <summary>
        /// Initializes parking garage with a given number of max parking spots, remaining parking spots, and the parking pass chosen.
        /// </summary>
        /// <param name="maxParkingSpots">Maximum parking capacity of parking garage.</param>
        /// <param name="remainingParkingSpots">Remaining parking spots of parking garage.</param>
        /// <param name="passChosen">Parking pass chosen associated to the parking garage.</param>
        public ParkingRental(int maxParkingSpots, int remainingParkingSpots, ParkingPass passChosen)
        {
            this.maxParkingSpots = maxParkingSpots;
            this.remainingParkingSpots = remainingParkingSpots;
            this.passChosen = passChosen;
        }

        /// <summary>
        /// Returns maximum parkings spots for parking garage.
        /// </summary>
        /// <returns>Maximum parking spots.</returns>
        public int GetMaxParkingSpots()
        {
            return this.maxParkingSpots;
        }

        /// <summary>
        /// Sets maximum parkings spots for parking garage.
        /// </summary>
        /// <param name="maxParkingSpots">Maximum parking spots.</param>
        public void SetMaxParkingSpots(int maxParkingSpots)
        {
            this.maxParkingSpots = maxParkingSpots;
        }

        /// <summary>
        /// Returns remaining parking spots for parking garage.
        /// </summary>
        /// <returns>Remaining parking spots.</returns>
        public int GetRemainingParkingSpots()
        {
            return this.remainingParkingSpots;
        }

        /// <summary>
        /// Sets remainingParkingSpots for parking garage.
        /// </summary>
        /// <param name="remainingParkingSpots">Remaining parking spots.</param>
        public void SetRemainingParkingSpots(int remainingParkingSpots)
        {
            this.remainingParkingSpots = remainingParkingSpots;
        }

        /// <summary>
        /// Returns parking pass chosen.
        /// </summary>
        /// <returns>Parking pass.</returns>
        public ParkingPass GetPassChosen()
        {
            return this.passChosen;
        }

        /// <summary>
        /// Returns cost of parking pass chosen.
        /// </summary>
        /// <returns>Cost of parking pass.</returns>
        public int GetCost()
        {
            const int MonthlyPassCost = 30;
            const int WeeklyPassCost = 15;
            const int YearlyPassCost = 90;
            const int DailyPassCost = 5;
            int cost = 0;
            
            switch (passChosen)
            {
                case ParkingPass.MonthlyPass:
                    cost = MonthlyPassCost;
                    break;
                case ParkingPass.WeeklyPass:
                    cost = WeeklyPassCost;
                    break;
                case ParkingPass.YearlyPass:
                    cost = YearlyPassCost;
                    break;
                case ParkingPass.DailyPass:
                    cost = DailyPassCost;
                    break;
            }
            return cost;
        }
    }
}
