using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Models
{
    public class Audit
    {
        public int AutidId { get; set; }
        public string PlayerName { get; set; }
        public DateTime CreatedDate { get; set; }
        public double Amount { get; set; }

        // Relation
        //[ForeignKey("AuditTypeId")]
        //public string AuditTypeId { get; set; }
        //public AuditType AuditTypes { get; set; }
    }
}
