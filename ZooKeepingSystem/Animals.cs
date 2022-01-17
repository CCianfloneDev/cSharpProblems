using System;
using System.Collections.Generic;

namespace ZooKeepingSystem
{
    /// <summary>
    /// Represents animals inside of Zoo. With a given list of types of species.
    /// </summary>
    public class Animals
    {
        private List<Species> animals = new List<Species>();

        /// <summary>
        /// Initializes array of animals with given species.
        /// </summary>
        /// <param name="animals">Array of animals</param>
        public Animals(List<Species> animals)
        {
            this.animals = animals;
        }

        /// <summary>
        /// Returns number of animals in list of species.
        /// </summary>
        /// <returns>Number of animals.</returns>
        public int GetNumberOfAnimals()
        {
            return animals.Count;
        }

        /// <summary>
        /// Prints list of animals.
        /// </summary>
        /// <returns>Species.</returns>
        public void PrintSpecies()
        {
            foreach(Species animal in animals)
            {
                Console.WriteLine($"{animal.ToString()}");
            }
        }

        /// <summary>
        /// Adds a specie of animal to list of animals
        /// </summary>
        /// <param name="animalToAdd">Animal to add to list.</param>
        public void AddSpecies(Species animalToAdd)
        {
            animals.Add(animalToAdd);  
        }

        /// <summary>
        /// Removes a specified specie from list of animals.
        /// </summary>
        /// <param name="animalToRemove"></param>
        /// <returns></returns>
        public void RemoveSpecies(Species animalToRemove)
        {
            animals.Remove(animalToRemove);
        }
    }
}
