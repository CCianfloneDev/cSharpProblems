/* Author: Cole Cianflone
 * Date: Jan 13th, 2022
 */
namespace ParkingSystem
{
    /// <summary>
    /// Represents different parking passes..
    /// </summary>
    public enum ParkingPass
    {
        /// <summary>
        /// Daily parking pass.
        /// </summary>
        DailyPass = 1,

        /// <summary>
        /// Weekly parking pass.
        /// </summary>
        WeeklyPass = 2,

        /// <summary>
        /// Monthly parking pass.
        /// </summary>
        MonthlyPass = 3,

        /// <summary>
        /// Yearly parking pass.
        /// </summary>
        YearlyPass = 4,

        /// <summary>
        /// No parking pass.
        /// </summary>
        None = 5
    }
}
