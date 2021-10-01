using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routing.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List(string id = "All")
        {
            return Content("Product controller, List action, id: " + id);
        }

        // unlike normal method numbers are set to 0 by default when no parameter is passed
        public IActionResult Detail(int id)
        {
            return Content("Product controller, Detail action, id: " + id);
        }
    }
}
