using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AlbumsApp.Models;

namespace AlbumsApp.Controllers
{
    public class StudioController : Controller
    {
        public StudioController(AlbumsDbContext albumsDbContext)
        {
            _albumsDbContext = albumsDbContext;
        }

        public IActionResult List()
        {
            List<Studio> studios = _albumsDbContext.Studios.OrderBy(s => s.Name).ToList();
            return View(studios);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new Studio());
        }

        [HttpPost]
        public IActionResult Add(Studio studio)
        {
            _albumsDbContext.Studios.Add(studio);
            _albumsDbContext.SaveChanges();

            return RedirectToAction("List", "Album");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Studio studio = _albumsDbContext.Studios.Where(a => a.StudioId == id).FirstOrDefault();
            return View(studio);
        }

        [HttpPost]
        public IActionResult Edit(Studio studio)
        {
            _albumsDbContext.Studios.Update(studio);
            _albumsDbContext.SaveChanges();

            return RedirectToAction("List", "Album");
        }

        private AlbumsDbContext _albumsDbContext;
    }
}
