using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EticketPractice.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        // Relationships
        public List<ActorMovie> ActorMovies { get; set; }
    }
}
