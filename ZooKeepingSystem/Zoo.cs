using System;

namespace ZooKeepingSystem
{
    /// <summary>
    /// Represents a zoo.
    /// </summary>
    public class Zoo
    {
        public int NumberOfCages
        {
            get;
            set;
        }

        public int NumberOfZooKeepers
        {
            get;
            set;
        }

        public Animals AnimalsInZoo
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a zoo with a set number of cages, number of zoo keepers, and list of animals.
        /// </summary>
        /// <param name="numberOfCages">Number of cages.</param>
        /// <param name="numberOfZooKeepers">Total number of zoo keepers employed.</param>
        /// <param name="animals">Animals.</param>
        public Zoo(int numberOfCages, int numberOfZooKeepers, Animals animals)
        {
            NumberOfCages = numberOfCages;
            NumberOfZooKeepers = numberOfZooKeepers;
            AnimalsInZoo = animals;
        }
        
        /// <summary>
        /// Returns a string representation of the zoo.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return $"Number of cages at zoo: {NumberOfCages}\nNumber of animals: {AnimalsInZoo}\nTotal zoo keepers employed: {NumberOfZooKeepers}\n";
        }
    }
}
