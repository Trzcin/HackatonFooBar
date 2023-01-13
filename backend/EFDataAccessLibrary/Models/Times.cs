using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.Models
{
    public class Times
    {
        public int Id { get; set; }

        [Required]
        public int Walking { get; set; }

        [Required]
        public int Cycling { get; set; }

        [Required]
        public int PublicTransport { get; set; }
    }
}
