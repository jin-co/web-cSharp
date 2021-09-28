using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A1_TransactionRecord.Models
{
    // Transaction record class that stores the information
    // about transaction record
    public class TransactionRecordKbaek7943
    {
        #region Properties
        public int TransactionRecordKbaek7943Id { get; set; }

        [Required(ErrorMessage = "Please enter a ticket symbol.")]
        public string TicketSymbol { get; set; }

        [Required(ErrorMessage = "Please enter a company name")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Please enter a quantity")]
        public int? Quantity { get; set; }

        [Required(ErrorMessage = "Please enter a share price")]
        public double? SharePrice { get; set; }

        [Required(ErrorMessage = "Please select a transaction type")]
        public string TransactionTypeId { get; set; }

        public TransactionType TrasactionType { get; set; }
        #endregion

        #region Methods
        // Calculates Gross value using quantity and share price
        // and returns value with or without the parenthesis 
        // depending on the transaction type
        public string CalculateGrossValue()
        {
            if (TransactionTypeId.Equals("Buy"))
            {
                double? calculatedValue = Quantity * SharePrice;
                return "(" + calculatedValue.ToString() + ")";
            }
            else
            {
                double? calculatedValue = Quantity * SharePrice;
                return calculatedValue.ToString();
            }            
        }

        // Calculates Gross value using gross value and commission
        // and returns value with or without the parenthesis 
        // depending on the transaction type
        public string CalculateNetValue()
        {
            if (TransactionTypeId.Equals("Buy"))
            {
                double? calculatedValue = (Quantity * SharePrice) + TrasactionType.Commission;
                return "(" + calculatedValue.ToString() + ")";
            }
            else
            {
                double? calculatedValue = (Quantity * SharePrice) - TrasactionType.Commission;
                return calculatedValue.ToString();
            }
        }
        #endregion
    }
}
