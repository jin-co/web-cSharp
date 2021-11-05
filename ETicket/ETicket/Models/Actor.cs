﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETicket.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        
        [Display(Name = "Profile Picture URL")]  // this will be displayed title
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        // Relationship
        public List<ActorMovie> ActorMovies { get; set; }
    }
}
