using System;
using Microsoft.AspNetCore.Mvc;
using CheatSheetCSharp.Models;
using CheatSheetCSharp.Models.Data;
using CheatSheetCSharp.Credential.Models;

namespace CheatSheetCSharp.Credential.Controllers
{
    [Area("Credential")]
    public class HomeController : Controller
    {
        private Repository<Book> data { get; set; }
        public HomeController(AppDbContext ctx) => data = new Repository<Book>(ctx);

        public ViewResult Index()
        {
            var random = data.Get(new QueryOptions<Book> {
                OrderBy = b => Guid.NewGuid()
            });

            return View(random);
        }

    }
}