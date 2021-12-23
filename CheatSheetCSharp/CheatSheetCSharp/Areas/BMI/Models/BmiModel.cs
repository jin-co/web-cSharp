using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheatSheetCSharp.Areas.BMI.Models
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
            } 
            else
            {
                return Math.Round(Weight / (Height * Height), 6);
            }
        }
    }
}
