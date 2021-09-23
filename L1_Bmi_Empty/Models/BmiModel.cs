using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace L1_Bmi_Empty.Models
{
    public class BmiModel
    {
        public double Height { get; set; }
        public double Weight { get; set; }

        public BmiModel() {}

        public double CalculateBMI()
        {
            double result = 2;
            if (Height == 0.0)
            {
                return 0.0;
            }
            else
            {
                return result;
            }
        }
    }
}
