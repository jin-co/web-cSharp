using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using AlbumsApp.Models;
using AlbumsApp.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace AlbumsApp.Controllers
{
    public class AlbumController : Controller
    {
        public AlbumController(AlbumsDbContext albumsDbContext)
        {
            _albumsDbContext = albumsDbContext;
        }

        [Route("/")]
        public IActionResult List()
        {
            // page visit count
            int visitCountSession = 0;
            if (HttpContext.Session.Keys.Contains("VisitCountSession"))
            {
                visitCountSession =  
                    (int)HttpContext.Session.GetInt32("VisitCountSession");
                visitCountSession++;
                HttpContext.Session.SetInt32("VisitCountSession", visitCountSession);
            }
            else
            {
                 HttpContext.Session.SetInt32("VisitCountSession", visitCountSession);
            }
            ViewBag.SessionCount = visitCountSession;

            int visitCountCookie = 0;
            if (Request.Cookies["VisitCountCookie"] != null)
            {
                visitCountCookie =
                    int.Parse(Request.Cookies["VisitCountCookie"]);                    
                visitCountCookie++;
                Response.Cookies.Append("VisitCountCookie", visitCountCookie.ToString());
            }
            else
            {
                Response.Cookies.Append("VisitCountCookie", visitCountCookie.ToString());
            }
            ViewBag.CookieCount = visitCountCookie;


            var albums = _albumsDbContext.Albums
                .Include(a => a.Studio)
                .OrderByDescending(a => a.YearProduced)
                .ToList();
            return View(albums);
        }

        public IActionResult AlbumsInStudio(int studioId, string studioName)
        {
            var albums = _albumsDbContext.Albums
                .Include(a => a.Studio)
                .Where(a => a.StudioId == studioId)
                .OrderByDescending(a => a.YearProduced)
                .ToList();
            ViewBag.Studio = studioName;
            return View(albums);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Add()
        {
            var viewModel = new AddOrEditAlbumViewModel();
            viewModel.AllStudios = GetAllStudios();
            return View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(AddOrEditAlbumViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _albumsDbContext.Albums.Add(viewModel);
                _albumsDbContext.SaveChanges();

                return RedirectToAction("List", "Album");
            }
            else
            {
                ModelState.AddModelError("", "There were errors in the form - please fix them and try adding again.");
                viewModel.AllStudios = GetAllStudios();
                return View(viewModel);
            }
        }

        [HttpGet]
        [Authorize]
        public IActionResult Edit(int id)
        {
            AddOrEditAlbumViewModel viewModel = new AddOrEditAlbumViewModel(_albumsDbContext.Albums.Include(a => a.Studio).Where(a => a.AlbumId == id).FirstOrDefault());
            viewModel.AllStudios = GetAllStudios();
            return View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Edit(AddOrEditAlbumViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _albumsDbContext.Albums.Update(viewModel);
                _albumsDbContext.SaveChanges();

                return RedirectToAction("List", "Album");
            }
            else
            {
                ModelState.AddModelError("", "There were errors in the form - please fix them and try updating again.");
                viewModel.AllStudios = GetAllStudios();
                return View(viewModel);
            }
        }

        [HttpGet]
        [Authorize]
        public IActionResult DeleteConfirmation(int id)
        {
            Album album = _albumsDbContext.Albums.Include(a => a.Studio).Where(a => a.AlbumId == id).FirstOrDefault();
            return View(album);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Delete(int id)
        {
            Album album = _albumsDbContext.Albums.Include(a => a.Studio).Where(a => a.AlbumId == id).FirstOrDefault();
            _albumsDbContext.Albums.Remove(album);
            _albumsDbContext.SaveChanges();

            return RedirectToAction("List", "Album");
        }

        [HttpGet("/Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private List<Studio> GetAllStudios()
        {
            return _albumsDbContext.Studios.OrderBy(s => s.Name).ToList();
        }

        private AlbumsDbContext _albumsDbContext;
    }
}
