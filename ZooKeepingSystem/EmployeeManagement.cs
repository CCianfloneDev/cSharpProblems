using System;

namespace ZooKeepingSystem
{
    /// <summary>
    /// Represents an employee management system.
    /// </summary>
    public class EmployeeManagement
    {
        private Zoo zooName;

        /// <summary>
        /// Initializes an employee management system with a given zoo.
        /// </summary>
        /// <param name="zooName">Name of zoo associated with system.</param>
        public EmployeeManagement(Zoo zooName)
        {
            this.zooName = zooName;       
        }

        /// <summary>
        /// Hires employee.
        /// </summary>
        public void HireEmployee()
        {
            zooName.SetNumberOfZooKeepers(zooName.GetNumberOfZooKeepers() + 1);
        }

        /// <summary>
        /// Fires employee.
        /// </summary>
        public void FireEmployee()
        {
            zooName.SetNumberOfZooKeepers(zooName.GetNumberOfZooKeepers() - 1);
        }

        /// <summary>
        /// Displays menu.
        /// </summary>
        /// <returns>Menu with 4 options.</returns>
        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("(1) View Employees");
            Console.WriteLine("(2) Hire Employee");
            Console.WriteLine("(3) Fire Employee");
            Console.WriteLine("(4) Exit");
            Console.Write("Chose an option: ");

            switch(Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"There is currently: {zooName.GetNumberOfZooKeepers()}");
                    Console.WriteLine("Press any key to move on.");
                    Console.ReadKey();
                    goto default;
                case "2":
                    HireEmployee();
                    Console.WriteLine("Employee entered in system.");
                    Console.WriteLine("Press any key to move on.");
                    Console.ReadKey();
                    goto default;
                case "3":
                    FireEmployee();
                    Console.WriteLine("Employee removed from system.");
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
