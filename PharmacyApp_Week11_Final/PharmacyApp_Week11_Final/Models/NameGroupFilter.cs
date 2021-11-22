using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyApp_Week11_Final.Models
{
    public class NameGroupFilter
    {
        public int NameGroupId { get; set; }
        public string GroupName { get; set; }
        public char LowerLetter { get; set; }
        public char UpperLetter { get; set; }
    }
}
