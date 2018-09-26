using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhereIsMyCoffee.ValueObjects
{
    public class Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Location(double lat, double lon)
        {
            Latitude = lat;
            Longitude = lon;
        }
    }
}
