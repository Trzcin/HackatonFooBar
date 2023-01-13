using EFDataAccessLibrary.Models;

namespace DataInitializer
{
    public class CsvManager
    {
        static public List<Place> GetListOfPlaceFromCsvFile(string path, string category)
        {
            return File.ReadAllLines(path)
                .Skip(1)
                .Select(line => line.Split(','))
                .Select(row => new Place
                {
                    Lat = Convert.ToDouble(row[0]),
                    Lon = Convert.ToDouble(row[1]),
                    Category = category,
                    Title = row[3],
                    Link = row[4]
                }).ToList();
        }
    }
}