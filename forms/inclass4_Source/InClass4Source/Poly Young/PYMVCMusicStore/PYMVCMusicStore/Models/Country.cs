using System;
using System.Collections.Generic;

#nullable disable

namespace PYMVCMusicStore.Models
{
    public partial class Country
    {
        public Country()
        {
            Orders = new HashSet<Order>();
            Provinces = new HashSet<Province>();
        }

        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string PostalPattern { get; set; }
        public string PhonePattern { get; set; }
        public string ProvinceStateLabel { get; set; }
        public double RetailTaxRate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Province> Provinces { get; set; }
    }
}
