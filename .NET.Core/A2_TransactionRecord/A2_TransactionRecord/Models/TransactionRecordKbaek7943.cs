﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace A2_TransactionRecord.Models
{
    // Transaction record class that stores the information
    // about transaction record
    public class TransactionRecordKbaek7943
    {
        #region Properties
        [Key]
        public int TransactionRecordKbaek7943Id { get; set; }

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

        [Required(ErrorMessage = "Please select a transaction type")]
        [ForeignKey("TransactionTypeId")]
        public string TransactionTypeId { get; set; }

        public TransactionType TransactionType { get; set; }

        [ForeignKey("CompanyId")]
        public int CompanyId { get; set; }

        public Company Company { get; set; }
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
                return String.Format("({0:n2})", calculatedValue);
            }
            else
            {
                double? calculatedValue = Quantity * SharePrice;
                return String.Format("{0:n2}", calculatedValue);
            }
        }

        // Calculates Gross value using gross value and commission
        // and returns value with or without the parenthesis 
        // depending on the transaction type
        public string CalculateNetValue()
        {
            if (TransactionTypeId.Equals("Buy"))
            {
                double? calculatedValue = (Quantity * SharePrice) + TransactionType.Commission;
                return String.Format("({0:n2})", calculatedValue);
            }
            else
            {
                double? calculatedValue = (Quantity * SharePrice) - TransactionType.Commission;
                return String.Format("{0:n2}", calculatedValue);
            }
        }
        #endregion
    }
}