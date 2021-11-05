using ETicket.Data;
using ETicket.Data.Services;
using ETicket.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicket.Controllers
{
    public class ActorsController : Controller
    {
        //* Directly accessing DB
        //private readonly AppDbContext context;

        //public ActorsController(AppDbContext context)
        //{
        //    this.context = context;
        //}

        //public IActionResult Index()
        //{
        //    var data = context.Actors.ToList();
        //    return View(data);
        //}

        //* Using Services to access DB
        private readonly IActorsService service;

        public ActorsController(IActorsService service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await service.GetAll();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(
            [Bind("FullName, ProfilePictureURL, Bio")]Actor actor)
        {
            if (ModelState.IsValid)
            {
                return View(actor);
            }
            service.Add(actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
