using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Prep.Models
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }

        [Required]
        //[StringLength(64)]
        [MaxLength(64)]
        public string Name { get; set; }
        public string Address { get; set; }

        [Url(ErrorMessage = "Invalid URL")]
        public string Website { get; set; }
        public string City { get; set; }

        [RegularExpression(@"^\d{5}$")]
        public string ZipCode { get; set; }

        // to access all cars
        public ICollection<Car> Cars { get; set; }
    }
}
