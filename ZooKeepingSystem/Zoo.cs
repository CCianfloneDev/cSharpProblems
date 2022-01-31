using System;

namespace ZooKeepingSystem
{
    /// <summary>
    /// Represents a zoo.
    /// </summary>
    public class Zoo
    {
        /// <summary>
        /// Gets and sets number of cages.
        /// </summary>
        public int NumberOfCages
        {
            get;
            set;
        }

        /// <summary>
        /// Gets and sets number of zoo keepers.
        /// </summary>
        public int NumberOfZooKeepers
        {
            get;
            set;
        }

        /// <summary>
        /// Gets and set animals in the zoo.
        /// </summary>
        public Animals AnimalsInZoo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets and sets the name of the zoo.
        /// </summary>
        public string ZooName
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes a zoo with a set number of cages, number of zoo keepers, and list of animals.
        /// </summary>
        /// <param name="numberOfCages">Number of cages.</param>
        /// <param name="numberOfZooKeepers">Total number of zoo keepers employed.</param>
        /// <param name="animals">Animals.</param>
        /// <param name="zooName">Name of the zoo.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when initialized with no name.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when number of cages or number of zoo keepers is less than zero.
        /// </exception>
        public Zoo(string zooName, int numberOfCages, int numberOfZooKeepers, Animals animals)
        {
            if (zooName == null)
            {
                throw new ArgumentNullException("Name", "Name cannot be null.");
            }
            if (numberOfCages < 0)
            {
                throw new ArgumentOutOfRangeException("NumberOfCages", "Argument cannot be less than zero.");
            }
            if (numberOfZooKeepers < 0)
            {
                throw new ArgumentOutOfRangeException("NumberOfZooKeepers", "Argument cannot be less than zero.");
            }

            ZooName = zooName;
            NumberOfCages = numberOfCages;
            NumberOfZooKeepers = numberOfZooKeepers;
            AnimalsInZoo = animals;
        }

        /// <summary>
        /// Initializes a zoo with a name, 0 cages, 1 zoo keeper, and no animals in the care.
        /// </summary>
        /// <param name="zooName">The name of the zoo.</param>
        public Zoo(string zooName) : this(zooName, 1, 1, null)
        {
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
