using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingSystem;

/* Main program to test ParkingGarage
 * Author: Cole Cianflone
 * Date: Jan 13th, 2022
 */
namespace ParkingGarageProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            const int MaxParkingSpots = 55;
            int remainingParkingSpots = 55;
            int passNumberSelected;
            ParkingPass passChosen = ParkingPass.None;

            const int SentinelValue = 9;

            do
            {
                Console.Clear();
                // input
                Console.WriteLine($"Rent a spot in the parking garage. Remaining Spots: {remainingParkingSpots}");
                Console.WriteLine("Press 9 to exit...");
                Console.WriteLine("DailyPass: $5 (1), WeeklyPass: $15 (2), MonthlyPass: $30 (3), YearlyPass: $90 (4)");
                Console.Write("Please choose a parking pass (Enter number 1 - 4): ");

                passNumberSelected = Convert.ToInt32(Console.ReadLine());

                switch (passNumberSelected)
                {
                    case int n when (n > 4 || n < 1):
                        Console.WriteLine("Please enter a valid choice between 1 - 4");
                        break;
                    case 1:
                        passChosen = ParkingPass.DailyPass;
                        remainingParkingSpots--;
                        break;
                    case 2:
                        passChosen = ParkingPass.WeeklyPass;
                        remainingParkingSpots--;
                        break;
                    case 3:
                        passChosen = ParkingPass.MonthlyPass;
                        remainingParkingSpots--;
                        break;
                    case 4:
                        passChosen = ParkingPass.YearlyPass;
                        remainingParkingSpots--;
                        break;
                }

            } while (passNumberSelected != SentinelValue);

            ParkingRental Spot01 = new ParkingRental(MaxParkingSpots, remainingParkingSpots, passChosen);

            // testing
            Console.WriteLine($" Maximum Parking spots: {Spot01.GetMaxParkingSpots()}");
            Console.WriteLine($" Remaining Parking spots: {Spot01.GetRemainingParkingSpots()}");
            Console.WriteLine($" Pass Chosen: {Spot01.GetPassChosen()}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
