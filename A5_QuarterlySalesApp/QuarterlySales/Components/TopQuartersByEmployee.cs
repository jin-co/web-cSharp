using Microsoft.AspNetCore.Mvc;
using QuarterlySales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterlySales.Components
{
    public class TopQuartersByEmployee : ViewComponent
    {
        private SalesContext _context;

        public TopQuartersByEmployee(SalesContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
