using System;

namespace ZooKeepingSystem
{
    /// <summary>
    /// Represents a zoo.
    /// </summary>
    public class Zoo
    {
        private string zooName;
        private int numberOfZooKeepers;
        private int numberOfCages;

        /// <summary>
        /// Gets and sets number of cages.
        /// </summary>
        public int NumberOfCages
        {
            get
            {
                return this.numberOfCages;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Argument cannot be less than zero.");
                }
                this.numberOfCages = value;
            }
        }

        /// <summary>
        /// Gets and sets number of zoo keepers.
        /// </summary>
        public int NumberOfZooKeepers
        {
            get
            {
                return this.numberOfZooKeepers;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Argument cannot be less than zero.");
                }
                this.numberOfZooKeepers = value;
            }
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
        /// Gets the name of the zoo.
        /// </summary>
        public string ZooName
        {
            get
            {
                return this.zooName;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Name cannot be null.");
                }
                this.zooName = value;
            }
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
            ZooName = zooName;
            NumberOfCages = numberOfCages;
            NumberOfZooKeepers = numberOfZooKeepers;
            AnimalsInZoo = animals;
        }

        /// <summary>
        /// Initializes a zoo with a name, 1 cages, 1 zoo keeper, and no animals in the care.
        /// </summary>
        /// <param name="zooName">The name of the zoo.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when initialized with no name.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when number of cages or number of zoo keepers is less than zero.
        /// </exception>
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
