using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuarterlySales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterlySales.Components
{
    // view component that shows the most sale by quarters
    public class TopQuartersByEmployee : ViewComponent
    {
        private SalesContext _context;

        public TopQuartersByEmployee(SalesContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(string input)
        {
            int quarter = 0;
            var sale = new List<Sales>();

            int count = 0;
            if (HttpContext.Session.GetInt32("TopCount") != null)
            {
                count = (int)HttpContext.Session.GetInt32("TopCount");
            }            

            if (int.TryParse(input, out quarter))
            {
                sale = _context.Sales
                .Where(a => a.Quarter == quarter)
                .OrderByDescending(a => a.Amount)
                .Take(count)
                .ToList();
            }
            else
            {
                sale = _context.Sales                
                .OrderByDescending(a => a.Amount)
                .Take(count)
                .ToList();
            }            
            return View(sale);
        }
    }
}
