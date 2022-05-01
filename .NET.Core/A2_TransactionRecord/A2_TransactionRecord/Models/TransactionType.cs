using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2_TransactionRecord.Models
{
    // Transaction type class that stores the information
    // about transaction type record
    public class TransactionType
    {
        #region Properties
        public string TransactionTypeId { get; set; }
        public string Name { get; set; }
        public double Commission { get; set; }
        #endregion
    }
}
