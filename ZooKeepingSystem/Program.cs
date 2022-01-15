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
            // declaring new list to pass to animals
            List<Species> listOfAnimals = new List<Species> {Species.Monkey, Species.Penguin, Species.Giraffe, Species.Tiger, Species.Gorilla};
            Animals animals = new Animals(listOfAnimals);
            
            // initializing Zoo with given number of cages, zoo keepers, and list of animals.
            Zoo AssinaboineZoo = new Zoo(5, 6, animals);

            Console.WriteLine(AssinaboineZoo.ToString());
            Console.WriteLine($"Animals at zoo: ");
            animals.PrintSpecies();

            Console.WriteLine("\n\n");

            animals.RemoveSpecies(listOfAnimals[0]);
            animals.PrintSpecies();

            Console.WriteLine("\n\n");

            animals.AddSpecies(Species.Giraffe);
            animals.PrintSpecies();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
