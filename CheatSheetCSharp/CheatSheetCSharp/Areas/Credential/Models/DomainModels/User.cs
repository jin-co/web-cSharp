using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CheatSheetCSharp.Credential.Models.DomainModels
{
    public class User : IdentityUser
    {
        // You can add properties/methods specific to the app's needs (will revisit later)
        [NotMapped]
        public IList<string> RoleNames { get; set; }
    }
}
