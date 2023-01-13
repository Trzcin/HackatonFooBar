using EFDataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataInitializer
{
    static public class DataProvider
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

        static public MapEdges GetMapEdges(this List<Place> places)
        {
            MapEdges edges = new MapEdges();
            edges.MinLat = places.Select(place => place.Lat).Min();
            edges.MaxLat = places.Select(place => place.Lat).Max();
            edges.MinLon = places.Select(place => place.Lon).Min();
            edges.MaxLon = places.Select(place => place.Lon).Max();
            return edges;
        }
    }
}
