﻿using System;
using System.Collections.Generic;

#nullable disable

namespace JKMusicStore.Models
{
    public partial class Province
    {
        public Province()
        {
            Orders = new HashSet<Order>();
        }

        public string ProvinceCode { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string RetailTaxCode { get; set; }
        public double RetailTaxRate { get; set; }
        public bool IncludesFederalTax { get; set; }

        public virtual Country CountryCodeNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
