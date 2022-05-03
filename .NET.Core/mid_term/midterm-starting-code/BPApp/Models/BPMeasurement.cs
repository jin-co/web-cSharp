using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPApp.Models
{
    /// <summary>
    /// https://www.heart.org/en/health-topics/high-blood-pressure/understanding-blood-pressure-readings
    /// </summary>
    public class BPMeasurement
    {
        public int BPMeasurementId { get; set; }

        public int Systolic { get; set; }

        public int Diastolic { get; set; }

        // Date the measurement was taken that defaults to today
        public DateTime MeasurementDate { get; set; } = DateTime.Now;
    }
}
