using System;
using System.Collections.Generic;

namespace ZooKeepingSystem
{
    /// <summary>
    /// Represents an animal management system.
    /// </summary>
    public class AnimalManagement
    {
        private Animals animals;
        private Species species;

        /// <summary>
        /// Initializes animal management system with associated animals.
        /// </summary>
        /// <param name="zooName">Zoo name.</param>
        /// <param name="animals">Animal name.</param>
        public AnimalManagement(Animals animals)
        {
            this.animals = animals;
        }

        /// <summary>
        /// Prints list of species in zoo.
        /// </summary>
        public void ShowSpecies()
        {
            animals.PrintSpecies();
        }

        /// <summary>
        /// Adds a specified species to list of animals.
        /// </summary>
        /// <param name="species">Name of species.</param>
        public void AddSpecies(Species speciesToAdd)
        {
            animals.AddSpecies(speciesToAdd);
        }

        /// <summary>
        /// Removes a specified species from list of animals.
        /// </summary>
        /// <param name="species">Name of species.</param>
        public void RemoveSpecies(Species species)
        {
            animals.RemoveSpecies(species);
        }

        /// <summary>
        /// Displays menu.
        /// </summary>
        /// <returns>A menu with 4 options</returns>
        public bool DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("(1) How many animals");
            Console.WriteLine("(2) Add animal");
            Console.WriteLine("(3) Remove animal");
            Console.WriteLine("(4) Exit");
            Console.Write("Chose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"There are : {animals.GetNumberOfAnimals()} animals");
                    return true;
                case "2":
                    Console.WriteLine($"Species added");
                    animals.AddSpecies(species);
                    return true;
                case "3":
                    Console.WriteLine("Species removed");
                    animals.RemoveSpecies(species);
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        }
    }
}
