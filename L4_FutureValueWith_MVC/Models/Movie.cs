using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace L4_FutureValueWith_MVC.Models
{
    public class Movie
    {
        // EF core will configure the database to generate this values
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1900, 2200, ErrorMessage = "Year must be after 1900 and before 2201.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1900, 2200, ErrorMessage = "Rating must be between 1 and 5.")]
        public int? Rating { get; set; }
    }
}
