using EFDataAccessLibrary.Models;

namespace MapCalculation
{
    static public class Distance
    {
        static public double GetDistance(this Place place, double lat, double lon)
        {
            double first = place.Lat - lat;
            double second = place.Lon - lon; 

            return Math.Sqrt(first * first + second * second);
        }
    }
}