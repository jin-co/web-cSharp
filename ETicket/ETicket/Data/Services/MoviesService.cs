using ETicket.Data.Base;
using ETicket.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicket.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        private readonly AppDbContext context;
        public MoviesService(AppDbContext context) : base(context) 
        {
            this.context = context;
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails = context.Movies
                .Include(c => c.Cinema)
                .Include(p => p.Producer)
                .Include(am => am.ActorMovies).ThenInclude(a => a.Actor)
                .FirstOrDefaultAsync(n => n.Id == id);
            return await movieDetails;
                
        }
    }
}
