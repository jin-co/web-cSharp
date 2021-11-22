using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PatientApp_Week11.Models.DBGenerated
{
    [Table("pharmacy_accounts")]
    [Index(nameof(PharmacyDescription), Name = "UQ__pharmacy__A39F0CE02C9D00C6", IsUnique = true)]
    public partial class PharmacyAccount
    {
        public PharmacyAccount()
        {
            Patients = new HashSet<Patient>();
            PrescriptionLineItems = new HashSet<PrescriptionLineItem>();
        }

        [Key]
        [Column("pharmacy_number")]
        public int PharmacyNumber { get; set; }
        [Column("pharmacy_description")]
        [StringLength(50)]
        public string PharmacyDescription { get; set; }

        [InverseProperty(nameof(Patient.DefaultPharmacyNumberNavigation))]
        public virtual ICollection<Patient> Patients { get; set; }
        [InverseProperty(nameof(PrescriptionLineItem.PharmacyNumberNavigation))]
        public virtual ICollection<PrescriptionLineItem> PrescriptionLineItems { get; set; }
    }
}
