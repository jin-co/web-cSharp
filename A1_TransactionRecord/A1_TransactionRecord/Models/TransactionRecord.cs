﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A1_TransactionRecord.Models
{
    public class TransactionRecord
    {
        public int TransactionId { get; set; }
        [Required(ErrorMessage="")]
        public string TicketSymbol { get; set; }
        [Required(ErrorMessage="")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage="")]
        public int Quantity { get; set; }
        [Required(ErrorMessage="")]
        public double SharePrice { get; set; }
        //public int CommissionFee { get; set; }
        //public int GrossValue { get; set; }
        //public int NetValue { get; set; }

    }
}