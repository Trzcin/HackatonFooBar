using EFDataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInitializer
{
    public class DataProvider
    {
        static public List<Place> InitData()
        {
            List<Place> places = new List<Place>();
            foreach (var item in Utils.CategoryToPaths)
            {
                item.Value.ForEach(file =>
                {
                    string path = $"{Utils.basePath}{file}{Utils.extension}";
                    places.AddRange(CsvManager.GetListOfPlaceFromCsvFile(path, item.Key));
                });
            }

            return places;
        }
    }
}
