using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Prep.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // FK to navigate back to manufacturer
        public int ManufacturerId { get; set; }
        // navigation property to associate cars to a manufacturer
        public Manufacturer Manufacturer { get; set; }

        // to access all parts
        public ICollection<Part> Parts { get; set; }
    }
}
