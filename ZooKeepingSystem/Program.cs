using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooKeepingSystem;

namespace ZooKeepingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sentinelValueEntered = false;
            int optionChosen;

            // declaring new list to pass to animals
            List<Species> listOfAnimals = new List<Species>();

            foreach (Species s in Enum.GetValues(typeof(Species)))
            {
                listOfAnimals.Add(s);
            }
            
            Animals animals = new Animals(listOfAnimals);
            // initializing Zoo with given number of cages, zoo keepers, and list of animals.
            Zoo AssinaboineZoo = new Zoo("Assinaboine Zoo", 7, 5, animals);

            // initializing menus
            EmployeeManagement employeeSystem = new EmployeeManagement(AssinaboineZoo);
            EquipmentManagement equipmentSystem = new EquipmentManagement(AssinaboineZoo);
            AnimalManagement animalSystem = new AnimalManagement(animals, AssinaboineZoo);

            do
            {
                Console.WriteLine("ZooKeepingSystem");
                Console.WriteLine(AssinaboineZoo.ZooName);
                Console.WriteLine("Designed by: Cole Cianflone\nPlease choose an option 1 - 3.");
                Console.WriteLine("Press 9 to exit.");
                Console.WriteLine(" Option (1): Employee management\n Option (2): Equipment management\n Option (3): Animal management");

                // Try catch stops user from entering an unexpected format. I.E any key other than the options 1-3 & 9
                try
                {
                    optionChosen = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Clear();
                    continue;
                }

                Console.Clear();
                switch (optionChosen)
                { 
                    case 9:
                        sentinelValueEntered = true;
                        break;
                    case 1:
                        Console.WriteLine("Employee management entered.");
                        employeeSystem.DisplayMenu();
                        break;
                    case 2:
                        Console.WriteLine("Equipment management entered.");
                        equipmentSystem.DisplayMenu();
                        break;
                    case 3:
                        Console.WriteLine("Animal management entered.");
                        animalSystem.DisplayMenu();
                        break;
                    default:
                        Console.WriteLine("Main menu entered.");
                        break;
                }

            } while (!sentinelValueEntered);
        }
    }
}
