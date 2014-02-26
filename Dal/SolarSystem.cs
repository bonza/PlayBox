using Play1;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class SolarSystem: DbContext
    {
        public DbSet<Planet> Planets { get; set; }
    }
}
