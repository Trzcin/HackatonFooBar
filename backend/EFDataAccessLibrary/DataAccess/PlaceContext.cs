using EFDataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.DataAccess
{
    public class PlaceContext : DbContext
    {
        public PlaceContext(DbContextOptions options) : base(options) { }
        public DbSet<Place> Places { get; set; }
        public DbSet<MapEdges> MapEdges { get; set; }
    }
}
