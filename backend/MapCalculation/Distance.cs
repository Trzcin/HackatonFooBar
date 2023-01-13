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

        static public Times ToTime(this double distance)
        {
            return new Times
            {
                Walking = (int)(distance / 0.0006666667),
                Cycling = (int)(distance / 0.0002222222),
                PublicTransport = (int)(distance / 0.00021)
            };
        }
    }
}