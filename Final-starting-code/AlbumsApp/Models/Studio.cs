using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumsApp.Models
{
    public class Studio
    {
        public int StudioId { get; set; }

        [Required(ErrorMessage = "Name Required")]
        [MaxLength(64, ErrorMessage = "Name connot be greater than 64 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "URL Required")]
        [Url(ErrorMessage = "Invalid URL")]
        public string Url { get; set; }

        [Required(ErrorMessage = "Address Required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City Required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Zip code Required")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Invalid format (00000)")]
        public string ZipCode { get; set; }
    }
}
