using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Prep.Models
{
    public class Part
    {
        public int PartId { get; set; }
        public string PartName { get; set; }
        public int ItemsInStock { get; set; }
        public double Price { get; set; }

        // FK to navigate back to car
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
