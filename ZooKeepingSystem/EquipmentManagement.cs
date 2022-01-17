using System;

namespace ZooKeepingSystem
{
    /// <summary>
    /// Represents an equipment management system.
    /// </summary>
    public class EquipmentManagement
    {
        private Zoo zooName;

        /// <summary>
        /// Initializes equipment management system with an associated zoo.
        /// </summary>
        /// <param name="zooName">A zoo.</param>
        public EquipmentManagement(Zoo zooName)
        {
            this.zooName = zooName;
        }

        /// <summary>
        /// Gets current count of cages.
        /// </summary>
        /// <returns>Number of cages.</returns>
        public int GetCurrentCageCount()
        {
            return zooName.GetNumberOfCages();
        }

        /// <summary>
        /// Adds cage.
        /// </summary>
        public void AddCage()
        {
            zooName.SetNumberOfCages(GetCurrentCageCount() + 1);
        }

        /// <summary>
        /// Removes a cage.
        /// </summary>
        public void RemoveCage()
        {
            zooName.SetNumberOfCages(GetCurrentCageCount() - 1);
        }

        /// <summary>
        /// Displays menu.
        /// </summary>
        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("(1) View Cages");
            Console.WriteLine("(2) Add Cages");
            Console.WriteLine("(3) Remove cages");
            Console.WriteLine("(4) Exit");
            Console.Write("Chose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"There is currently: {zooName.GetNumberOfCages()}");
                    Console.WriteLine("Press any key to move on.");
                    Console.ReadKey();
                    goto default;
                case "2":
                    AddCage();
                    Console.WriteLine("Cage added to system.");
                    Console.WriteLine("Press any key to move on.");
                    Console.ReadKey();
                    goto default;
                case "3":
                    RemoveCage();
                    Console.WriteLine("Cage removed.");
                    Console.WriteLine("Press any key to move on.");
                    Console.ReadKey();
                    goto default;
                case "4":
                    Console.WriteLine("Press any key to leave menu.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    DisplayMenu();
                    break;
            }
        }
    }
}
