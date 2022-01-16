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
        /// <returns>Menu with 4 options</returns>
        public bool DisplayMenu()
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
                    return true;
                case "2":
                    Console.WriteLine($"Cage added.");
                    AddCage();
                    return true;
                case "3":
                    Console.WriteLine("Cage removed.");
                    RemoveCage();
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        }
    }
}
