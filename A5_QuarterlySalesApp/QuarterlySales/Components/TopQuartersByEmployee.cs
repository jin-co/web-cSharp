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

        public IViewComponentResult Invoke(string input)
        {
            int quarter = 0;
            var sale = new List<Sales>();

            if (int.TryParse(input, out quarter))
            {
                sale = _context.Sales
                .Where(a => a.Quarter == quarter)
                .OrderByDescending(a => a.Amount)
                .Take(3)
                .ToList();
            }
            else
            {
                sale = _context.Sales                
                .OrderByDescending(a => a.Amount)
                .Take(3)
                .ToList();
            }
            
            return View(sale);
        }
    }
}
