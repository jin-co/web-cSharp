using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CheatSheetCSharp.Session.Models
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }

        [DisplayName("Company Name")]
        public string Name { get; set; }

        public string Address { get; set; }

        public string TickerSymbol { get; set; }
    }
}
