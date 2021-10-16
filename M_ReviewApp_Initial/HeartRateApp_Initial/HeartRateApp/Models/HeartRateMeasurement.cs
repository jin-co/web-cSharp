using System;
using System.ComponentModel.DataAnnotations;

namespace HeartRateApp.Models
{
    public class HeartRateMeasurement
    {
        // Primary key field
        [Key]
        public int HeartRateMeasurementId { get; set; }

        // Beats per minute (BPM) value
        [Required(ErrorMessage = "Please enter a BPM (beats per minute) value.")]
        [Range(30, 300, ErrorMessage = "BPM values must be an integer between 30 and 300.")]
        public int? BPMValue { get; set; }

        // The timestamp of when the measurement was taken with a default value of now
        [Required(ErrorMessage = "Please enter a date for the measurement.")]
        public DateTime MeasurementDate { get; set; } = DateTime.Now;

    }
}
