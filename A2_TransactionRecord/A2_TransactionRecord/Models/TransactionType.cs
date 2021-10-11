using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2_TransactionRecord.Models
{
    public class TransactionType
    {
        public string TransactionTypeId { get; set; }
        public string Name { get; set; }
        public double Commission { get; set; }
    }
}
