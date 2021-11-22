using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PatientApp_Week11.Models.DBGenerated
{
    [Table("prescriptions")]
    [Index(nameof(PrescriptionDate), Name = "prescriptions_prescription_date_ix")]
    public partial class Prescription
    {
        public Prescription()
        {
            PrescriptionLineItems = new HashSet<PrescriptionLineItem>();
        }

        [Key]
        [Column("prescription_id")]
        public int PrescriptionId { get; set; }
        [Column("patient_id")]
        public int PatientId { get; set; }
        [Required]
        [Column("prescription_number")]
        [StringLength(50)]
        public string PrescriptionNumber { get; set; }
        [Column("prescription_date", TypeName = "datetime")]
        public DateTime PrescriptionDate { get; set; }
        [Column("prescription_total", TypeName = "decimal(9, 2)")]
        public decimal PrescriptionTotal { get; set; }
        [Column("health_insurance_id")]
        public int HealthInsuranceId { get; set; }

        [ForeignKey(nameof(HealthInsuranceId))]
        [InverseProperty("Prescriptions")]
        public virtual HealthInsurance HealthInsurance { get; set; }
        [ForeignKey(nameof(PatientId))]
        [InverseProperty("Prescriptions")]
        public virtual Patient Patient { get; set; }
        [InverseProperty(nameof(PrescriptionLineItem.Prescription))]
        public virtual ICollection<PrescriptionLineItem> PrescriptionLineItems { get; set; }
    }
}
