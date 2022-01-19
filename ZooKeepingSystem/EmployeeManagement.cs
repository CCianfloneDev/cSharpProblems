using System;

namespace ZooKeepingSystem
{
    /// <summary>
    /// Represents an employee management system.
    /// </summary>
    public class EmployeeManagement
    {
        private Zoo zoo;

        /// <summary>
        /// Initializes an employee management system with a given zoo.
        /// </summary>
        /// <param name="zoo">Name of zoo associated with system.</param>
        public EmployeeManagement(Zoo zoo)
        {
            this.zoo = zoo;       
        }

        /// <summary>
        /// Hires employee.
        /// </summary>
        public void HireEmployee()
        {
            zoo.SetNumberOfZooKeepers(zoo.GetNumberOfZooKeepers() + 1);
        }

        /// <summary>
        /// Fires employee.
        /// </summary>
        public void FireEmployee()
        {
            zoo.SetNumberOfZooKeepers(zoo.GetNumberOfZooKeepers() - 1);
        }

        /// <summary>
        /// Displays menu.
        /// </summary>
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
                    Console.WriteLine($"There is currently: {zoo.GetNumberOfZooKeepers()}");
                    EmployeeManagement.ConfirmMessage();
                    break;
                case "2":
                    HireEmployee();
                    Console.WriteLine("Employee entered in system.");
                    EmployeeManagement.ConfirmMessage();
                    break;
                case "3":
                    FireEmployee();
                    Console.WriteLine("Employee removed from system.");
                    EmployeeManagement.ConfirmMessage();
                    break;
                case "4":
                    EmployeeManagement.ConfirmMessage("Press any key to leave menu.");
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
            EmployeeManagement.ConfirmMessage("Press any key to continue...");
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
