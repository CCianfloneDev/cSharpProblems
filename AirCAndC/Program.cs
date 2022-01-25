using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirCandC_api;

namespace AirCandC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Amenities> amenities = new List<Amenities>();
            amenities.Add(Amenities.Pool);
            amenities.Add(Amenities.MovieRoom);
            AirCCPropertyListing listing01 = new AirCCPropertyListing(2, 2, 1500, "1080 Fleming avenue", RenterPackages.Weekly, 500, amenities);

            Console.WriteLine(listing01.ToString());

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
