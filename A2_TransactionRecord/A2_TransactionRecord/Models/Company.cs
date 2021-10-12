using System;
using System.Collections.Generic;
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
        
        public string Name { get; set; }

        public string Address { get; set; }

        public string TickerSymbol { get; set; }
        #endregion
    }
}
