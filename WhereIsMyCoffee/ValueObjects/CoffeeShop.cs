using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhereIsMyCoffee.ValueObjects
{
    public class CoffeeShop
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }

        public CoffeeShop(Guid id, string name, Location location)
        {
            Id = id;
            Name = name;
            Location = location;
        }
    }
}
