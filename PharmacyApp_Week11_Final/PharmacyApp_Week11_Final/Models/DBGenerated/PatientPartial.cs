using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyApp_Week11_Final.Models.DBGenerated
{
    [ModelMetadataType(typeof(PatientMetaData))]
    public partial class Patient
    {

    }

    public class PatientMetaData
    {
        [Required]
        [RegularExpression("(?i)^[a-z0-9 ]+$", ErrorMessage = "Name may not contain special characters.")]
        public string PatientName { get; set; }

        [Required]
        public string PatientAddress1 { get; set; }

        [Required]
        public string PatientCity { get; set; }

        [Required]
        [RegularExpression("[^,]*[a-zA-Z]{2}", ErrorMessage = "State must be two characters long.")]
        public string PatientState { get; set; }

        [Required]
        [RegularExpression("(^\\d{5}(-\\d{4})?$)|(^[ABCEGHJKLMNPRSTVXY]{1}\\d{1}[A-Z]{1} *\\d{1}[A-Z]{1}\\d{1}$)", ErrorMessage = "Zip code is invalid.")] // US or Canada
        public string PatientZipCode { get; set; }

        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        [Remote("CheckPhoneNumber", "Validation", ErrorMessage = "Phone number already exists in the database.")]
        public string PatientPhone { get; set; }

        [Required]
        public int DefaultHealthInsuranceId { get; set; }

        [Required]
        public int DefaultPharmacyNumber { get; set; }
    }
}
