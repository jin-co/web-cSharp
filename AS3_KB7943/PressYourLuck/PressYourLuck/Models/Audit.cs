using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Models
{
    public class Audit
    {
        public Audit() { }

        public Audit(string playerName, DateTime createdDate, double amount, string auditTypeId)
        {
            PlayerName = playerName;
            CreatedDate = createdDate;
            Amount = amount;
            AuditTypeId = auditTypeId;
        }

        public int AuditId { get; set; }

        [DisplayName("Player Name")]
        public string PlayerName { get; set; }

        [DisplayName("Created")]
        public DateTime CreatedDate { get; set; }

        public double Amount { get; set; }

        // Relation
        [ForeignKey("AuditTypeId")]
        public string AuditTypeId { get; set; }

        [DisplayName("Audit Type")]
        public AuditType AuditTypes { get; set; }
    }
}
