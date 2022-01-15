namespace ZooKeepingSystem
{
    /// <summary>
    /// Represents a zoo.
    /// </summary>
    public class Zoo
    {
        private int numberOfCages;
        private int numberOfZooKeepers;
        private Animals animals;

        /// <summary>
        /// Initializes a zoo with a set number of cages, total number of animals, number of zoo keepers, and animals.
        /// </summary>
        /// <param name="numberOfCages">Number of cages.</param>
        /// <param name="numberOfZooKeepers">Total number of zoo keepers employed.</param>
        /// <param name="animals">Animals.</param>
        public Zoo(int numberOfCages, int numberOfZooKeepers, Animals animals)
        {
            this.numberOfCages = numberOfCages;
            this.numberOfZooKeepers = numberOfZooKeepers;
            this.animals = animals;
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
