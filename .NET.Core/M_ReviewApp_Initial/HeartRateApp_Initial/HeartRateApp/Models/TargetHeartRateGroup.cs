using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeartRateApp.Models
{
    public class TargetHeartRateGroup
    {
        public string TargetHeartRateGroupId { get; set; }
        public int Age { get; set; }
        public int LowerEndBPMValue { get; set; }
        public int UpperEndBPMValue { get; set; }
        public int AverageMaximumBPMValue { get; set; }
    }
}
