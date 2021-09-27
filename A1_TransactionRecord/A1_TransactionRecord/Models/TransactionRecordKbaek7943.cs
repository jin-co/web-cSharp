using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A1_TransactionRecord.Models
{
    // class that is going to be used to create a table
    public class TransactionRecordKbaek7943
    {
        public int TransactionRecordKbaek7943Id { get; set; }
        
        //[Required(ErrorMessage="")]
        public string TicketSymbol { get; set; }
        
        //[Required(ErrorMessage="")]
        public string CompanyName { get; set; }
        
        //[Required(ErrorMessage="")]
        public int Quantity { get; set; }
        
        //[Required(ErrorMessage="")]
        public double SharePrice { get; set; }

        //public string TransactionTypeId { get; set; }

        //public TransactionType TransactionType { get; set; }
    }
}
