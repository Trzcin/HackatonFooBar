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
            { "apteka", new List<string> { "apteka" } },
            { "atrakcje", new List<string> { "atrakcje", "entertainment", "touristattraction" } },
            { "bank", new List<string> { "bank" } },
            { "bar", new List<string> { "bar" } },
            { "basen", new List<string> { "basen" } },
            { "biblioteka", new List<string> { "biblioteka" } },
            { "biuro", new List<string> { "biuro", "office"} },
            { "catering", new List<string> { "catering" } },
            { "kościół", new List<string> { "church" } },
            { "cmentarz", new List<string> { "cmentarz" } },
            { "kawa", new List<string> { "coffee" } },
            { "cukiernia", new List<string> { "cukiernia" } },
            { "kultura", new List<string> { "culture" } },
            { "dentysta", new List<string> { "dentysta" } },
            { "drukarnia", new List<string> { "drukarnia" } },
            { "dzieci", new List<string> { "dzieci" } },
            { "fast food", new List<string> { "fastfood" } },
            { "fitness", new List<string> { "fitness" } },
            { "fotograf", new List<string> { "fotograf" } },
            { "fryzjer", new List<string> { "fryzjer" } },
            { "hotel", new List<string> { "hotel" } },
            { "impreza", new List<string> { "impreza" } },
            { "kawiarnia", new List<string> { "kawiarnia" } },
            { "krawiec", new List<string> { "krawiec" } },
            { "księgowa", new List<string> { "ksiegowa" } },
            { "las", new List<string> { "las" } },
            { "lekarz", new List<string> { "lekarz" } },
            { "mechanik", new List<string> { "mechanik" } },
            { "monopolowy", new List<string> { "monopolowy" } },
            { "muzeum", new List<string> { "muzeum" } },
            { "opieka zdrowotna", new List<string> { "opiekazdrowotna" } },
            { "ortodonta", new List<string> { "ortodonta" } },
            { "park", new List<string> { "park" } },
            { "piekarnia", new List<string> { "piekarnia" } },
            { "plac zabaw", new List<string> { "plac zabaw" } },
            { "plac", new List<string> { "plac" } },
            { "plaża", new List<string> { "plaza" } },
            { "pralnia", new List<string> { "pralnia" } },
            { "prawnik", new List<string> { "prawnik" } },
            { "przedszkole", new List<string> { "przedszkole" } },
            { "przychodnia", new List<string> { "przychodnia" } },
            { "pub", new List<string> { "pub" } },
            { "transport autokarowy", new List<string> { "public transport" } },
            { "remonty", new List<string> { "remonty" } },
            { "restauracje", new List<string> { "restauracje", "restaurant" } },
            { "szkoła", new List<string> { "school", "szkola" } },
            { "serwis rowerowy", new List<string> { "serwisrowerowy" } },
            { "sklep", new List<string> { "shop" } },
            { "galeria handlowa", new List<string> { "shopping mall" } },
            { "siłownia", new List<string> { "silownia" } },
            { "sklep spożywczy", new List<string> { "sklep spozywczy", "grocery store" } },
            { "sklep AGD", new List<string> { "sklepAGD" } },
            { "sport różny", new List<string> { "sport" } },
            { "sprzątanie", new List<string> { "sprzatanie" } },
            { "stacja benzynowa", new List<string> { "stacjapaliw" } },
            { "punkty transportu publicznego", new List<string> { "Stacje transportu publicznego" } },
            { "stolarz", new List<string> { "stolarz" } },
            { "transport wielkogabarytowy", new List<string> { "transport" } },
            { "uczelnia wyższa", new List<string> { "university" } },
            { "zbiornik wodny", new List<string> { "zbiornikwodny" } },
            { "żłobek", new List<string> { "zlobek" } },
            { "przystanki autobusowe", new List<string> { "autobus" } },
            { "przystanki tramwajowe", new List<string> { "tramwaj" } }
        };
    }
}
