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

        [Required(ErrorMessage = "Please enter a ticket symbol.")]
        public string TicketSymbol { get; set; }

        [Required(ErrorMessage = "Please enter a company name")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Please enter a quantity")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Please enter a share price")]
        public double SharePrice { get; set; }

        public string TransactionTypeId { get; set; }

        public TransactionType TrasactionType { get; set; }

        public string CalculateGrossValue()
        {
            if (TransactionTypeId.Equals("Buy"))
            {
                double calculatedValue = Quantity * SharePrice;
                return "(" + calculatedValue.ToString("c") + ")";
            }
            else
            {
                double calculatedValue = Quantity * SharePrice;
                return calculatedValue.ToString("c");
            }            
        }

        public string CalculateNetValue()
        {
            if (TransactionTypeId.Equals("Buy"))
            {
                double calculatedValue = (Quantity * SharePrice) + TrasactionType.Commission;
                return "(" + calculatedValue.ToString("c") + ")";
            }
            else
            {
                double calculatedValue = (Quantity * SharePrice) - TrasactionType.Commission;
                return calculatedValue.ToString("c");
            }
        }
    }
}
