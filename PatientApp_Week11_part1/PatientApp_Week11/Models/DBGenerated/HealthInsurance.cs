using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PatientApp_Week11.Models.DBGenerated
{
    [Table("health_insurances")]
    public partial class HealthInsurance
    {
        public HealthInsurance()
        {
            Patients = new HashSet<Patient>();
            Prescriptions = new HashSet<Prescription>();
        }

        [Key]
        [Column("health_insurance_id")]
        public int HealthInsuranceId { get; set; }
        [Required]
        [Column("health_insurance_description")]
        [StringLength(50)]
        public string HealthInsuranceDescription { get; set; }

        [InverseProperty(nameof(Patient.DefaultHealthInsurance))]
        public virtual ICollection<Patient> Patients { get; set; }
        [InverseProperty(nameof(Prescription.HealthInsurance))]
        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}
