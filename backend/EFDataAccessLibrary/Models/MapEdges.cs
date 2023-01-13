using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.Models
{
    public class MapEdges
    {
        public int Id { get; set; }

        [Required]
        public double MinLat { get; set; }

        [Required]
        public double MaxLat { get; set; }

        [Required]
        public double MinLon { get; set; }

        [Required]
        public double MaxLon { get; set; }

    }
}
