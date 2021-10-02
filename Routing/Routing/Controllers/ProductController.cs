using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routing.Controllers
{
    //[Route("Retail/[Controller] /[Action] /{id ?}")]
    public class ProductController : Controller
    {
        //public IActionResult List(string id = "All")
        //{
        //    return Content("Product controller, List action, id: " + id);
        //}

        //public IActionResult List(string cat, int num)
        //{
        //    return Content("Product controller, List action, category: " + cat +
        //        ", num: " + num);
        //}
        
        public IActionResult List(string id ="All", int page = 1, string sortBy = "Price")
        {
            return Content("Product controller, List action, " +
                "id: " + id +
                ", Page number: " + page +
                ", Sort By: " + sortBy);
        }

        // unlike normal method numbers are set to 0 by default when no parameter is passed
        public IActionResult Detail(int id)
        {
            return Content("Product controller, Detail action, id: " + id);
        }
    }
}
