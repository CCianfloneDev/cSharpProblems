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
        public bool DisplayMenu()
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
                    return true;
                case "2":
                    Console.WriteLine($"Employee entered in system.");
                    HireEmployee();
                    return true;
                case "3":
                    Console.WriteLine("Employee removed from system.");
                    FireEmployee();
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        }
    }
}
