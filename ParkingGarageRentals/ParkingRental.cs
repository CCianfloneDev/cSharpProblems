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
        private int _maxParkingSpots;
        
        public event EventHandler MaxParkingSpotsChanged;
        
        /// <summary>
        /// Gets maximum number of parking spots.
        /// </summary>
        public int MaxParkingSpots
        {
            get
            {
                return _maxParkingSpots;
            }
            
            private set
            {
                if(value < 1)
                {
                    throw new ArgumentOutOfRangeException("value", "There must be at least 1 parking spot.");
                }
                this._maxParkingSpots = value;
            };
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
        /// Gets the cost of parking pass chosen.
        /// </summary>
        public decimal Cost
        {
            get
            {
                const decimal MonthlyPassCost = 30;
                const decimal WeeklyPassCost = 15;
                const decimal YearlyPassCost = 90;
                const decimal DailyPassCost = 5;
                
                decimal cost = 0;
                
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
        
        /// <summary>
        /// Initializes parking garage with a given number of max parking spots, remaining parking spots, and the parking pass chosen.
        /// </summary>
        /// <param name="maxParkingSpots">Maximum parking capacity of parking garage.</param>
        /// <param name="remainingParkingSpots">Remaining parking spots of parking garage.</param>
        /// <param name="passChosen">Parking pass chosen associated to the parking garage.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when max parking spots is initialized below 1 or remaining parking spots is initialized below 0.
        /// </exception>
        public ParkingRental(int maxParkingSpots, int remainingParkingSpots, ParkingPass passChosen)
        {
            if(remainingParkingSpots < 0)
            {
                throw new ArgumentOutOfRangeException("remainingParkingSpots", "Argument cannot be less than zero.");
            }

            try
            {
                this.MaxParkingSpots = maxParkingSpots;
            }
            catch(ArgumentOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException("Invalid Parking Spots.", e);
            }
            
            this.RemainingParkingSpots = remainingParkingSpots;
            this.PassChosen = passChosen;

        }
        
        protected virtual void OnMaxParkingSpotsChanged(object sender, EventArgs e)
        {
            EventHandler maxParkingSpotsChanged = this.MaxParkingSpotsChanged;
            
            if(maxParkingSpotsChanged != null)
            {
                // $"Max Parking Spots Changed to {_maxParkingSpots}!"
                MaxParkingSpotsChanged(this, new EventArgs());
            }
        }
    }
}
