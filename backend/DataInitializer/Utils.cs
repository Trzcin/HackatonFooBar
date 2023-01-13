using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInitializer
{
    public class Utils
    {
        static public string basePath = "/initdata/";
        static public string extension = "_v1.csv";

        static public Dictionary<string, List<string>> CategoryToPaths = new()
        {
            {"retauracje", new List<string> { "restauracje", "restaurant" } },
            {"sklep spozywczy", new List<string> { "sklep spozywczy", "grocery store" } }
        };
    }
}
