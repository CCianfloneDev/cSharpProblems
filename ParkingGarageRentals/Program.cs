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
            int passNumberSelected = 0;
            ParkingPass passChosen = ParkingPass.None;

            bool isNotSentinelValue = true;

            do
            {
                // Clearing menu at start of loop.
                Console.Clear();

                // Taking user input.
                Console.WriteLine($"Rent a spot in the parking garage. Remaining Spots: {remainingParkingSpots}");
                Console.WriteLine("Press 9 to exit...");
                Console.WriteLine("DailyPass: $5 (1), WeeklyPass: $15 (2), MonthlyPass: $30 (3), YearlyPass: $90 (4)");
                Console.Write("Please choose a parking pass (Enter number 1 - 4): ");

                try
                {
                    passNumberSelected = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Must enter a valid number.");
                    Console.ReadKey();
                    continue;
                }
                if ((passNumberSelected < 1 || passNumberSelected > 4) && passNumberSelected != 9)
                {
                    Console.WriteLine("Please enter a valid choice between 1 - 4");
                    Console.ReadKey();
                }
                if (passNumberSelected == 9)
                {
                    isNotSentinelValue = false;
                }

                switch (passNumberSelected)
                {
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
                    default:
                        break;
                }
            } while (isNotSentinelValue);

            ParkingRental Spot01 = new ParkingRental(MaxParkingSpots, remainingParkingSpots, passChosen);

            // testing
            Console.WriteLine($" Maximum Parking spots: {Spot01.MaxParkingSpots}");
            Console.WriteLine($" Remaining Parking spots: {Spot01.RemainingParkingSpots}");
            Console.WriteLine($" Pass Chosen: {Spot01.PassChosen}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
