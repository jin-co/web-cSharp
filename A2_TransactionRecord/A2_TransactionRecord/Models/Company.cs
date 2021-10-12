using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A2_TransactionRecord.Models
{
    public class Company
    {
        #region Properties
        [Key]
        public int CompanyId { get; set; }
        
        [Required(ErrorMessage ="Please enter a company name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an address")]
        public string Address { get; set; }

        [DisplayName("Ticker Symbol")]
        [Required(ErrorMessage = "Please enter a ticker symbol")]
        public string TickerSymbol { get; set; }
        #endregion
    }
}
