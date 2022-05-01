using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Models
{
    public class AuditType
    {
        [Required(ErrorMessage = "Id Required")]
        public string AuditTypeId { get; set; }

        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }
    }
}
