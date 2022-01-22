using System;
using System.Collections.Generic;

namespace AirCandC_api
{
    /// <summary>
    /// Represents a rental property listing on Air C&C.
    /// </summary>
    public class AirCCPropertyListing
    {
        private int numberOfRooms;
        private int numberOfBathrooms;

        /// <summary>
        /// Gets square footage of rental property.
        /// </summary>
        public int SquareFootage 
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets address of rental property.
        /// </summary>
        public string Address
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets rent type offered.
        /// </summary>
        public RenterPackages RentTypeOffered
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets price for rent type offered.
        /// </summary>
        public int PriceForPackage
        {
            get;
            private set;
        }

        private List<Amenities> amenities = new List<Amenities>();

        /// <summary>
        /// Initializes a listing on Air c&c
        /// </summary>
        /// <param name="numberOfRooms">Number of rooms.</param>
        /// <param name="numberOfBathrooms">Number of bathrooms.</param>
        /// <param name="squareFootage">Square footage of property.</param>
        /// <param name="address">Address associated with property.</param>
        /// <param name="rentTypeOffered">Rent package associated with this listing (daily, weekly, monthly)</param>
        /// <param name="priceForPackage">Price associated with renting package chosen.</param>
        /// <param name="amenities">Amenities associated with this listing.</param>
        public AirCCPropertyListing(int numberOfRooms, int numberOfBathrooms, int squareFootage, 
            string address, RenterPackages rentTypeOffered, int priceForPackage, List<Amenities> amenities)
        {
            this.numberOfRooms = numberOfRooms;
            this.numberOfBathrooms = numberOfBathrooms;
            this.SquareFootage = squareFootage;
            this.Address = address;
            this.RentTypeOffered = rentTypeOffered;
            this.PriceForPackage = priceForPackage;
            this.amenities = amenities;
        }

        /// <summary>
        /// Gets number of rooms for property listing.
        /// </summary>
        public int GetNumberOfRooms()
        {
            return this.numberOfRooms;
        }

        /// <summary>
        /// Sets number of rooms for property listing.
        /// </summary>
        /// <param name="numberOfRooms">Number of rooms.</param>
        public void SetNumberOfRooms(int numberOfRooms)
        {
            this.numberOfRooms = numberOfRooms;
        }

        /// <summary>
        /// Gets number of bathrooms on property.
        /// </summary>
        /// <returns>Number of bathrooms.</returns>
        public int GetNumberOfBathrooms()
        {
            return numberOfBathrooms;
        }

        /// <summary>
        /// Sets number of bathrooms on property.
        /// </summary>
        /// <param name="numberOfBathrooms">Number of bathrooms.</param>
        public void SetNumberOfBathrooms(int numberOfBathrooms)
        {
            this.numberOfBathrooms = numberOfBathrooms;
        }

        /// <summary>
        /// Gets list of amenities offered on property.
        /// </summary>
        /// <returns>Amenities offered.</returns>
        public List<Amenities> GetAmenitiesOffered()
        {
            return this.amenities;
        }

        /// <summary>
        /// Prints amenities associated with property.
        /// </summary>
        public void PrintAmenities()
        {

            foreach (Amenities amenities in this.amenities)
            {
                Console.WriteLine($" {amenities} ");
            }
            if (amenities.Count <= 0)
            {
                Console.WriteLine(" No amenities.");
            }
        }

        /// <summary>
        /// Sets amenities offered on property.
        /// </summary>
        /// <param name="amenities">Amenities offered.</param>
        public void SetAmenitiesOffered(List<Amenities> amenities)
        {
            this.amenities = amenities;
        }

        /// <summary>
        /// Returns a string representation of the listing on Air c&c.
        /// </summary>
        /// <returns>Property listing.</returns>
        public override string ToString()
        {
            return $"Property listing on Air C&C:" +
                   $"\n Rooms: {GetNumberOfRooms()}" +
                   $"\n Bathrooms: {GetNumberOfBathrooms()}" +
                   $"\n Square footage: {SquareFootage}" +
                   $"\n Address: {Address}" +
                   $"\n Rent type: {RentTypeOffered}" +
                   $"\n Rent cost: {PriceForPackage}";
        }
    }
}
