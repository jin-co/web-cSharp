using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PatientApp_Week11.Models.DBGenerated
{
    [Table("patients")]
    [Index(nameof(PatientName), Name = "UQ__patients__AC3A2370E7A8FE7F", IsUnique = true)]
    public partial class Patient
    {
        public Patient()
        {
            Prescriptions = new HashSet<Prescription>();
        }

        [Key]
        [Column("patient_id")]
        public int PatientId { get; set; }
        [Required]
        [Column("patient_name")]
        [StringLength(256)]
        public string PatientName { get; set; }
        [Column("patient_address1")]
        [StringLength(128)]
        public string PatientAddress1 { get; set; }
        [Column("patient_address2")]
        [StringLength(128)]
        public string PatientAddress2 { get; set; }
        [Required]
        [Column("patient_city")]
        [StringLength(64)]
        public string PatientCity { get; set; }
        [Required]
        [Column("patient_state")]
        [StringLength(2)]
        public string PatientState { get; set; }
        [Required]
        [Column("patient_zip_code")]
        [StringLength(20)]
        public string PatientZipCode { get; set; }
        [Column("patient_phone")]
        [StringLength(50)]
        public string PatientPhone { get; set; }
        [Column("patient_contact_last_name")]
        [StringLength(128)]
        public string PatientContactLastName { get; set; }
        [Column("patient_contact_first_name")]
        [StringLength(128)]
        public string PatientContactFirstName { get; set; }
        [Column("patient_contact_email")]
        [StringLength(128)]
        public string PatientContactEmail { get; set; }
        [Column("default_health_insurance_id")]
        public int DefaultHealthInsuranceId { get; set; }
        [Column("default_pharmacy_number")]
        public int DefaultPharmacyNumber { get; set; }
        [Column("is_deleted")]
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(DefaultHealthInsuranceId))]
        [InverseProperty(nameof(HealthInsurance.Patients))]
        public virtual HealthInsurance DefaultHealthInsurance { get; set; }
        [ForeignKey(nameof(DefaultPharmacyNumber))]
        [InverseProperty(nameof(PharmacyAccount.Patients))]
        public virtual PharmacyAccount DefaultPharmacyNumberNavigation { get; set; }
        [InverseProperty(nameof(Prescription.Patient))]
        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}
