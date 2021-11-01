using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Bmi
    {
        public int Weight { get; set; }
        public int Height { get; set; }

        public int Calculate()
        {
            return Height / (Weight / 2);
        }
    }
}
