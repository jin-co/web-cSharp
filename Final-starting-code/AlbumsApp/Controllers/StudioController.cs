﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AlbumsApp.Models;
using Microsoft.AspNetCore.Authorization;

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
        [Authorize]
        public IActionResult Add()
        {
            return View(new Studio());
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(Studio studio)
        {
            if (ModelState.IsValid)
            {
                _albumsDbContext.Studios.Add(studio);
                _albumsDbContext.SaveChanges();

                return RedirectToAction("List", "Album");
            }
            else
            {
                ModelState.AddModelError("", "There are errors");
                return View(studio);
            }                        
        }

        [HttpGet]
        [Authorize]
        public IActionResult Edit(int id)
        {
            Studio studio = _albumsDbContext.Studios.Where(a => a.StudioId == id).FirstOrDefault();
            return View(studio);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Edit(Studio studio)
        {
            _albumsDbContext.Studios.Update(studio);
            _albumsDbContext.SaveChanges();

            return RedirectToAction("List", "Album");
        }

        private AlbumsDbContext _albumsDbContext;
    }
}
