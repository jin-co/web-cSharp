using ETicket.Data;
using ETicket.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicket.Controllers
{
    public class MoviesController : Controller
    {
        //private readonly AppDbContext context;

        //public MoviesController(AppDbContext context)
        //{
        //    this.context = context;
        //}

        private readonly IMoviesService service;

        public MoviesController(IMoviesService service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            //var moives = await context.Movies
            //    .Include(n => n.Cinema)
            //    .OrderBy(m => m.Name)
            //    .ToListAsync();
            //return View(moives);

            var moives = await service.GetAllAsync(n => n.Cinema);
            return View(moives);
        }
    }
}
