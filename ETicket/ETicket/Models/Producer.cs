using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ETicket.Models
{
    public class Producer
    {        
        public int ProducerId { get; set; }

        [DisplayName("ProFile Piture URL")]
        public string ProfilePictureURL { get; set; }

        [DisplayName("Full Name")]
        public string FullName { get; set; }
        
        public string Bio { get; set; }

        // Relationship
        public List<Movie> Movies { get; set; }
    }
}
