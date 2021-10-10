using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A2_TransactionRecord.Models
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
        [RegularExpression("^(?=.*[1-9])[0-9]*[.,]?[0-9]{1,2}$",
            ErrorMessage = "Quantity must be greater than 0")]
        //[Range(0, int.MaxValue)]
        public int? Quantity { get; set; }

        [Required(ErrorMessage = "Please enter a share price")]
        [RegularExpression("^(?=.*[1-9])[0-9]*[.,]?[0-9]{1,2}$",
            ErrorMessage = "Share price must be greater than 0")]
        //[Range(0, double.MaxValue)]
        public double? SharePrice { get; set; }
        #endregion
    }
}