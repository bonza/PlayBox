using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play1
{
    public class Planet
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }

        public int? DistanceFromSun { get; set; }

    }
}
