using System;

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
        /// <summary>
        /// Gets maximum number of parking spots.
        /// </summary>
        public int MaxParkingSpots
        {
            get; private set;
        }

        /// <summary>
        /// Gets remaining parking spots.
        /// </summary>
        public int RemainingParkingSpots
        {
            get; private set;
        }

        /// <summary>
        /// Gets parking pass chosen.
        /// </summary>
        public ParkingPass PassChosen
        {
            get; private set;
        }
        
        /// <summary>
        /// Initializes parking garage with a given number of max parking spots, remaining parking spots, and the parking pass chosen.
        /// </summary>
        /// <param name="maxParkingSpots">Maximum parking capacity of parking garage.</param>
        /// <param name="remainingParkingSpots">Remaining parking spots of parking garage.</param>
        /// <param name="passChosen">Parking pass chosen associated to the parking garage.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when max parking spots or remaining parking spots is initialized below zero.</exception>
        public ParkingRental(int maxParkingSpots, int remainingParkingSpots, ParkingPass passChosen)
        {
            if(maxParkingSpots < 0)
            {
                throw new ArgumentOutOfRangeException("maxParkingSpots", "Argument cannot be less than zero.");
            }
            if(remainingParkingSpots < 0)
            {
                throw new ArgumentOutOfRangeException("remainingParkingSpots", "Argument cannot be less than zero.");
            }


            this.MaxParkingSpots = maxParkingSpots;
            this.RemainingParkingSpots = remainingParkingSpots;
            this.PassChosen = passChosen;

        }

        /// <summary>
        /// Returns cost of parking pass chosen.
        /// </summary>
        /// <returns>Cost of parking pass.</returns>
        public int GetCost()
        {
            int cost = 0;
            const int MonthlyPassCost = 30;
            const int WeeklyPassCost = 15;
            const int YearlyPassCost = 90;
            const int DailyPassCost = 5;
            switch (PassChosen)
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
