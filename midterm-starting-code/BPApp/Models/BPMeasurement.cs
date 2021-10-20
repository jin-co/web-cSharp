using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BPApp.Models
{
    /// <summary>
    /// https://www.heart.org/en/health-topics/high-blood-pressure/understanding-blood-pressure-readings
    /// </summary>
    public class BPMeasurement
    {
        [Required(ErrorMessage = "Please enter ID")]
        public int BPMeasurementId { get; set; }

        [Required(ErrorMessage = "Please enter Systolic")]
        [Range(20, 400, ErrorMessage = "Systolic: Must be between 20 and 400")]
        public int Systolic { get; set; }

        [Required(ErrorMessage = "Please enter Diastolic")]
        [Range(10, 300, ErrorMessage = "Diastolic: Must be between 10 and 300")]
        public int Diastolic { get; set; }

        // Added properties
        [ForeignKey("PositionId")]
        public string PositionId { get; set; }

        public Position Positions { get; set; }



        // Date the measurement was taken that defaults to today
        public DateTime MeasurementDate { get; set; } = DateTime.Now;
    }
}
