using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace A4_AccountsPayable.Models.DBGenerated
{
    // partial class to add additional features to
    // the vendor class
    [ModelMetadataType(typeof(VendorMetaData))]
    public partial class Vendor
    {
    }

    public class VendorMetaData
    {                        
        [Required(ErrorMessage="Please enter name")]
        [RegularExpression("(?i)^[a-z0-9 ]+$", 
            ErrorMessage = "Name may not contain special characters.")]
        public string VendorName { get; set; }

        [Required(ErrorMessage = "Please enter address")]        
        public string VendorAddress1 { get; set; } 
                
        public string VendorAddress2 { get; set; }
        
        [Required(ErrorMessage="Please enter city")]                
        public string VendorCity { get; set; }

        [Required(ErrorMessage="Please enter state")]
        [RegularExpression("[^,]*[a-zA-Z]{2}", ErrorMessage = "State must be two characters long.")]
        public string VendorState { get; set; }

        [Required(ErrorMessage="Please enter zip code")]
        [RegularExpression("(^\\d{5}(-\\d{4})?$)|(^[ABCEGHJKLMNPRSTVXY]{1}\\d{1}[A-Z]{1} *\\d{1}[A-Z]{1}\\d{1}$)", 
            ErrorMessage = "Zip code is invalid.")] // US or Canada
        public string VendorZipCode { get; set; }

        [Required(ErrorMessage="Please enter phone")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", 
            ErrorMessage = "Entered phone format is not valid.")]
        [Remote("CheckPhoneNumber", "Validation",
            ErrorMessage = "Phone number already exists in the database.")]
        public string VendorPhone { get; set; }
        
        [Required(ErrorMessage = "Please enter term")]
        public int DefaultTermsId { get; set; }

        [Required(ErrorMessage = "Please enter account")]
        public int DefaultAccountNumber { get; set; }
    }
}
