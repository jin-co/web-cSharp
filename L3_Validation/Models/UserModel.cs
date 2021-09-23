using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace L3_Validation.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please fill in the first name")]
        [MinLength(3, ErrorMessage = "First Name: Must be longer than or equal to 3")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please fill in the last name")]
        [MaxLength(5, ErrorMessage = "Last Name: Must be shorter than 5")]
        public string LastName { get; set; }

        [Range(20, 50, ErrorMessage = "Age: Must be between 20 and 50")]
        public int Age { get; set; }

        [StringLength(20, ErrorMessage = "Maximum length is 20 characters")]
        public string Address { get; set; }

        [RegularExpression("[0-9]{10}", ErrorMessage = "Follow the format")]
        public int PhoneNumber { get; set; }
    }
}
