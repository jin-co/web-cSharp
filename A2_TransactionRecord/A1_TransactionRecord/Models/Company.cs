using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A2_TransactionRecord.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        
        [Required(ErrorMessage = "Please enter a company name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a address")]
        public string Address { get; set; }
        
        [Required(ErrorMessage = "Please enter a ticket symbol.")]
        public string TickerSymbol { get; set; }

    }
}
