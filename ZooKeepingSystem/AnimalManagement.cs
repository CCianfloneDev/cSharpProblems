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
        private Zoo zoo;

        /// <summary>
        /// Initializes animal management system with associated animals.
        /// </summary>
        /// <param name="zoo">Zoo name.</param>
        /// <param name="animals">Animal name.</param>
        public AnimalManagement(Animals animals, Zoo zoo)
        {
            this.animals = animals;
            this.zoo = zoo; 
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
        public void AddSpeciesToList()
        {
            Console.WriteLine("Choose a species from the list to add.");
            Console.WriteLine($"Options are:\n (11) Giraffe\n (12) Gorilla\n (13) Tiger\n (14) Monkey\n (15) Penguin");

            if (animals.GetNumberOfAnimals() >= zoo.GetNumberOfCages())
            {
                Console.WriteLine("Can't add animal. Not enough cages.");
            }
            else if (int.TryParse(Console.ReadLine(), out int animalNumber))
            {
                if (Enum.IsDefined(typeof(Species), animalNumber))
                {
                    Species animalToAdd = (Species)animalNumber;
                    animals.AddSpecies(animalToAdd);
                }
            }
        }

        /// <summary>
        /// Removes a specified species from list of animals.
        /// </summary>
        public void RemoveSpeciesFromList()
        {
            Console.WriteLine("Choose a species from the list to remove.");
            Console.WriteLine($"Options are:\n (11) Giraffe\n (12) Gorilla\n (13) Tiger\n (14) Monkey\n (15) Penguin");

            if (int.TryParse(Console.ReadLine(), out int animalNumber))
            {
                if (Enum.IsDefined(typeof(Species), animalNumber))
                {
                    Species animalToAdd = (Species)animalNumber;
                    animals.RemoveSpecies(animalToAdd);
                    Console.WriteLine("Species removed");
                }
            }
            else if (!Enum.IsDefined(typeof(Species), animalNumber))
            {
                Console.WriteLine("Invalid entry.");
            }
        }

        /// <summary>
        /// Displays menu.
        /// </summary>
        public void DisplayMenu()
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
                    AnimalManagement.ConfirmMessage();
                    break;
                case "2":
                    AddSpeciesToList();
                    AnimalManagement.ConfirmMessage();
                    break;
                case "3":
                    RemoveSpeciesFromList();
                    AnimalManagement.ConfirmMessage();
                    break;
                case "4":
                    AnimalManagement.ConfirmMessage();
                    return;
            }

            DisplayMenu();
        }

        /// <summary>
        /// Displays a prompt to allow user to press a key to continue.
        /// </summary>
        private static void ConfirmMessage()
        {
            AnimalManagement.ConfirmMessage("Press any key to continue...");
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
