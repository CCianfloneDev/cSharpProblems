using System;

namespace ZooKeepingSystem
{
    /// <summary>
    /// Represents a zoo.
    /// </summary>
    public class Zoo
    {
        private Animals animals;
        private string name;
        private int numberOfCages;
        private int numberOfZooKeepers;

        /// <summary>
        /// Initializes a zoo with a name, set number of cages, number of zoo keepers, and list of animals.
        /// </summary>
        /// <param name="name">The name of the zoo.</param>
        /// <param name="numberOfCages">Number of cages.</param>
        /// <param name="numberOfZooKeepers">Total number of zoo keepers employed.</param>
        /// <param name="animals">Animals.</param>
        public Zoo(string name, int numberOfCages, int numberOfZooKeepers, Animals animals)
        {
            this.name = name;
            this.animals = animals;
            this.numberOfCages = numberOfCages;
            this.numberOfZooKeepers = numberOfZooKeepers;
        }
        
        /// <summary>
        /// Initializes a zoo with a name, 0 cages, 1 zoo keeper, and no animals in the care.
        /// </summary>
        /// <param name="name">The name of the zoo.</param>
        public Zoo(string name) : this(name, 0, 1, null)
        {
        }

        /// <summary>
        /// Gets number of cages in zoo.
        /// </summary>
        /// <returns>Number of cages.</returns>
        public int GetNumberOfCages()
        {
            return this.numberOfCages;
        }

        /// <summary>
        /// Sets number of cages in zoo.
        /// </summary>
        /// <param name="numberOfCages">Number of cages.</param>
        public void SetNumberOfCages(int numberOfCages)
        {
            this.numberOfCages = numberOfCages;
        }

        /// <summary>
        /// Gets number of zoo keepers employees.
        /// </summary>
        /// <returns></returns>
        public int GetNumberOfZooKeepers()
        {
            return this.numberOfZooKeepers;
        }

        /// <summary>
        /// Sets number of zoo keepers currently employed.
        /// </summary>
        /// <param name="numberOfZooKeepers">Number of zoo keepers.</param>
        public void SetNumberOfZooKeepers(int numberOfZooKeepers)
        {
            this.numberOfZooKeepers = numberOfZooKeepers;
        }
        
        /// <summary>
        /// Returns a string representation of the zoo.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return $"Number of cages at zoo: {numberOfCages}\nNumber of animals: {animals.GetNumberOfAnimals()}\nTotal zoo keepers employed: {GetNumberOfZooKeepers()}\n";
        }
    }
}
