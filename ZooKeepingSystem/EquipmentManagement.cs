using System;

namespace ZooKeepingSystem
{
    /// <summary>
    /// Represents an equipment management system.
    /// </summary>
    public class EquipmentManagement
    {
        private Zoo zoo;

        /// <summary>
        /// Initializes equipment management system with an associated zoo.
        /// </summary>
        /// <param name="zoo">A zoo.</param>
        public EquipmentManagement(Zoo zoo)
        {
            this.zoo = zoo;
        }

        /// <summary>
        /// Gets current count of cages.
        /// </summary>
        /// <returns>Number of cages.</returns>
        public int GetCurrentCageCount()
        {
            return zoo.NumberOfCages;
        }

        /// <summary>
        /// Adds cage.
        /// </summary>
        public void AddCage()
        {
            zoo.NumberOfCages++;
        }

        /// <summary>
        /// Removes a cage.
        /// </summary>
        public void RemoveCage()
        {
            zoo.NumberOfCages--;
        }

        /// <summary>
        /// Displays the Equipment Management Menu.
        /// </summary>
        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Available options: ");
            Console.WriteLine("(1) View Cages");
            Console.WriteLine("(2) Add Cages");
            Console.WriteLine("(3) Remove cages");
            Console.WriteLine("(4) Exit");
            Console.Write("Chose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"There is currently: {zoo.NumberOfCages}");
                    EquipmentManagement.ConfirmMessage();
                    break;
                case "2":
                    AddCage();
                    Console.WriteLine("Cage added to system.");
                    EquipmentManagement.ConfirmMessage();
                    break;
                case "3":
                    RemoveCage();
                    Console.WriteLine("Cage removed.");
                    EquipmentManagement.ConfirmMessage();
                    break;
                case "4":
                    EquipmentManagement.ConfirmMessage("Press any key to leave menu.");
                    Console.Clear();
                    return;
            }

            DisplayMenu();
        }

        /// <summary>
        /// Displays a prompt to allow user to press a key to continue.
        /// </summary>
        private static void ConfirmMessage()
        {
            EquipmentManagement.ConfirmMessage("Press any key to continue...");
        }

        /// <summary>
        /// Displays a custom prompt and allows user to press a key to continue.
        /// </summary>
        /// <param name="message">The custom message to deliver to the user.</param>
        private static void ConfirmMessage(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
