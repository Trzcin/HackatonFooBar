
namespace fileRead {

    public class CSVRow
    {
        public double lat;
        public double lon;
        public string type;
        public string title;
        public string link;
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<CSVRow> result;
            string jsonString;
            using (TextReader fileReader = File.OpenText("TestData.csv"))
            {
                var csv = new CsvReader(fileReader);
                csv.Configuration.HasHeaderRecord = false;
                csv.Read();
                result = csv.GetRecords<Userdetails>().ToList();
            }

            //Csv data as Json string if needed
            jsonString = JsonConvert.SerializeObject(result);
            foreach (UserDetails details in result)
            {
                Console.WriteLine(details.Name + " " + details.ID + " " + details.City + " " + details.Country);
            }
        }
    }
}