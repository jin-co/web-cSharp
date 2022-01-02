using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using CheatSheetCSharp.Session.Models;
using CheatSheetCSharp.Models.Data;

namespace CheatSheetCSharp.Session.Controllers
{
    [Area("Session")]
    public class EmployeesController : Controller
    {
        private readonly AppDbContext _context;

        // Prepare controller for database context communication
        public EmployeesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Employees/Index/sortOrder
        // Returns a list of employee records to the Index.cshtml view page under the "Employees" view folder.
        // In addition, a sortOrder query string is passed back to this method to allow the sorting of employee
        // records in either an ascending order by company name (e.g. "SortByAsc") or by descending order 
        // (e.g. "SortByDesc").
        public IActionResult Index(string sortOrder)
        {
            // Additional logic to add a cookie (called newUser) which will be created upon navigating to this
            // page with the cookie option set to expiration within 20 seconds of its creation time. This cookie
            // will update the message shown on the Index page found within the Home controller (not needed for
            // assignment 2).
            CookieOptions cookieOptions = new CookieOptions { Expires = DateTime.Now.AddSeconds(20) };
            HttpContext.Response.Cookies.Append("newUser", "Randy", cookieOptions);

            // ViewBag "SortOrder" used to flip the provided sortOrder passed from the view every time this view
            // page is rendered in order to reverse the sequence in which the employee records are listed based on
            // the sortOrder specified as follow.
            ViewBag.SortOrder = sortOrder == "SortByAsc" || sortOrder == null ? 
                "SortByDesc" : "SortByAsc";

            var employees = _context.Employees
                .Include(i => i.Role)
                .Include(i => i.Company)
                .ToList();

            // Alter the listing entry display based on the sortOrder that is currently being passed
            // to this method through the use of this switch case statement.
            switch (sortOrder)
            {
                case "SortByAsc":
                    employees = employees.OrderBy(ob => ob.Company.Name).ToList();
                    break;

                case "SortByDesc":
                    employees = employees.OrderByDescending(obd => obd.Company.Name).ToList();
                    break;

                default:
                    employees = employees.OrderBy(ob => ob.Company.Name).ToList();
                    break;
            }

            // Return newly sorted employees list based on sort order
            return View(employees);
        }

        // Gets and returns a filtered list of employees based on provided CompanyID to filter
        // down the entire list of employees to only show specific only to one company.
        public IActionResult EmployeeList(int id)
        {
            Company company = _context.Companies.Where(w => w.CompanyID == id).FirstOrDefault();

            ViewBag.CompanyName = company.Name;
            ViewBag.TickerSymbol = company.TickerSymbol;

            var employeeList = _context.Employees
                .Include(i => i.Role)
                .Include(i => i.Company)
                .Where(w => w.CompanyID == id)
                .ToList();

            return View(employeeList);
        }

        // GET: Employees/Details/5
        // Returns the information (fields) associated to a specific Employee entry in the Details.cshml view page.
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Attempt to locate an employee record in the Employee table where the EmployeeID matches the passed id 
            // to this method.
            var employee = _context.Employees.FirstOrDefault(m => m.EmployeeID == id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        // Returns the Create.cshtml view page from the Employee view folder.
        public IActionResult Create()
        {
            ViewBag.Roles = _context.Roles.ToList();
            ViewBag.Companies = _context.Companies.ToList();
            return View();
        }

        // POST: Employees/Create
        // Add a new Company entry to the database and redirect user to Index.cshtml of the Employees view folder.
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                _context.SaveChanges();

                // Creating/setting new TempData variable (called action and isSuccessful) that returns success message
                // of newly added Employee entry to the database (See _Layout.cshtml page for TempData reference).
                TempData["action"] = employee.FirstName + " " + employee.LastName + " was added to the employee database.";
                TempData["isSuccessful"] = "Success";

                return RedirectToAction("Index");
            }

            // Creating/setting new TempData variable (called action and isSuccessful) that returns failed message
            // of attempting to add new Employee entry to the database (See _Layout.cshtml page for TempData reference).
            TempData["action"] = employee.FirstName + " " + employee.LastName + " was NOT added to the employee database.";
            TempData["isSuccessful"] = "Failed";

            return View(employee);
        }

        // GET: Employees/Edit/5
        // Returns the retrieved Employee entry from the database to the Edit.cshtml view page that matches the supplied
        // id passed to the method.
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewBag.Roles = _context.Roles.ToList();
            ViewBag.Companies = _context.Companies.ToList();

            // Attempt to locate an employee record in the Employee table where the Employee ID matches the passed id 
            // to this method.
            var employee = _context.Employees.Find(id);

            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // If the ModelState is valid, then proceed to update the employee entry with the updated values as inserted
        // from the Edit.cshtml view page under the Employees view folder.
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                // Creating/setting new TempData variable (called action and isSuccessful) that returns success message
                // when updating existing Employee entry in the database (See _Layout.cshtml page for TempData reference).
                TempData["action"] = employee.FirstName + " " + employee.LastName + " was updated.";
                TempData["isSuccessful"] = "Success";

                return RedirectToAction(nameof(Index));
            }

            // Creating/setting new TempData variable (called action and isSuccessful) that returns success message
            // when updating existing Employee entry in the database (See _Layout.cshtml page for TempData reference).
            TempData["action"] = employee.FirstName + " " + employee.LastName + " was NOT updated.";
            TempData["isSuccessful"] = "Failed";

            return View(employee);
        }

        // GET: Employees/Delete/5
        // Attempts to retrieve the employee entry associated to the passed employee ID in order to proceed to delete
        // the entry with the confirmation of the user.
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Attempts to find a matching employee entry in the database with the matching EmployeeID entry as passed
            // to this method.
            var employee = _context.Employees.FirstOrDefault(m => m.EmployeeID == id);
            
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        // Attempts to remove an entry entirely from the database if the employee record is found in the database
        // based on matching EmployeeID provided and after user clicked on "Delete" to confirm the action.
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Employee employee)
        {
            // Attempts to remove an entry entirely from the database if the employee record is found in the database
            // based on matching EmployeeID provided and after user clicked on "Delete" to confirm the action.
            TempData["action"] = employee.FirstName + " " + employee.LastName + " was deleted from the employee database.";
            TempData["isSuccessful"] = "Success";

            //var employee = _context.Employees.Find(id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // Local method to assist with the process of identifying if the employee entry exists in the 
        // database based on whether or not the provided EmployeeID matches a record in the Employee
        // table.
        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeID == id);
        }
    }
}
