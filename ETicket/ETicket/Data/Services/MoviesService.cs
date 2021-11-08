using ETicket.Data.Base;
using ETicket.Data.ViewModels;
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

        public async Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues()
        {
            //var response = new NewMovieDropdownsVM();
            //response.Actors = await context.Actors.OrderBy(n => n.FullName).ToListAsync();
            //response.Cinemas = await context.Cinemas.OrderBy(n => n.Name).ToListAsync();
            //response.Producers = await context.Producers.OrderBy(n => n.FullName).ToListAsync();

            //return response;

            var response = new NewMovieDropdownsVM()
            {
                Actors = await context.Actors.OrderBy(n => n.FullName).ToListAsync(),
                Cinemas = await context.Cinemas.OrderBy(n => n.Name).ToListAsync(),
                Producers = await context.Producers.OrderBy(n => n.FullName).ToListAsync()
            };
            return response;
        }
    }
}
