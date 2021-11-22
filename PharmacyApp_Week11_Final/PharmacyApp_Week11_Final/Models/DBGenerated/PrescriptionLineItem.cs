using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PharmacyApp_Week11_Final.Models.DBGenerated
{
    [Table("prescription_line_items")]
    public partial class PrescriptionLineItem
    {
        [Key]
        [Column("prescription_id")]
        public int PrescriptionId { get; set; }
        [Key]
        [Column("prescrition_sequence")]
        public int PrescritionSequence { get; set; }
        [Column("pharmacy_number")]
        public int PharmacyNumber { get; set; }
        [Column("line_item_amount", TypeName = "decimal(9, 2)")]
        public decimal LineItemAmount { get; set; }
        [Required]
        [Column("line_item_description")]
        [StringLength(100)]
        public string LineItemDescription { get; set; }

        [ForeignKey(nameof(PharmacyNumber))]
        [InverseProperty(nameof(PharmacyAccount.PrescriptionLineItems))]
        public virtual PharmacyAccount PharmacyNumberNavigation { get; set; }
        [ForeignKey(nameof(PrescriptionId))]
        [InverseProperty("PrescriptionLineItems")]
        public virtual Prescription Prescription { get; set; }
    }
}
