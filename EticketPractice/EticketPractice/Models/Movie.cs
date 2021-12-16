using EticketPractice.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EticketPractice.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        // Relationships
        public List<ActorMovie> ActorMovies { get; set; }

        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }

        public int ProducerId { get; set; }
        public Producer Producer { get; set; }

    }
}
