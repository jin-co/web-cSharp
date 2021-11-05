using ETicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicket.Controllers
{    
    public class ProducersController : Controller
    {
        private readonly AppDbContext context;

        public ProducersController(AppDbContext context)
        {
            this.context = context;
        }

        // getting data asynchronously
        public async Task<IActionResult> Index()
        {
            var allProducers = await context.Producers.ToListAsync();
            return View();
        }
    }
}
