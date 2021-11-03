using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Test
    {
        [Required(ErrorMessage = "required")]        
        public string Name { get; set; }

        [Required(ErrorMessage = "required")]
        public string Address { get; set; }
    }
}
