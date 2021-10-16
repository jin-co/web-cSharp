using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("TargetHeartRateGroupId")]
        public string TargetHeartRateGroupId { get; set; }

        public TargetHeartRateGroup TargetHeartRateGroup { get; set; }

        public string GetCategory()
        {
            if (BPMValue < TargetHeartRateGroup.LowerEndBPMValue)
            {
                return "Below";
            }
            else if (BPMValue >= TargetHeartRateGroup.LowerEndBPMValue &&
                BPMValue <= TargetHeartRateGroup.UpperEndBPMValue)
            {
                return "In Range";
            }
            else if (BPMValue > TargetHeartRateGroup.LowerEndBPMValue &&
                BPMValue <= TargetHeartRateGroup.UpperEndBPMValue)
            {
                return "Above Range";
            }
            else
            {
                return "Above Average Maximum";
            }
        }
    }
}
