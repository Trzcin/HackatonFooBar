using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.Models
{
    public class Category
    {
        public string Name { get; set; }
        public Place Nearest { get; set; }
        public Times Times { get; set; }

    }
}
