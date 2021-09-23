using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace L1_Bmi.Models
{
    public class BmiModel
    {
        public BmiModel() {}

        public double Height { get; set; }
        public double Weight { get; set; }

        public double CalculateBMI()
        {
            if (Height == 0)
            {
                return 0.0;
            } else
            {
                return Weight / (Height * Height);
            }
        }


    }
}
