using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeesApplication_Week5.Models;

namespace EmployeesApplication_Week5.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly EmployeeContext _context;

        // Prepare controller for database context communication
        public CompaniesController(EmployeeContext context)
        {
            _context = context;
        }

        // GET: Companies/Index
        // Returns a list of company records to the Index.cshtml view page under the "Companies" view folder
        public IActionResult Index()
        {
            return View(_context.Companies.ToList());
        }

        // GET: Companies/Details/5
        // Returns the information (fields) associated to a specific Company entry in the Details.cshml view page.
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Attempt to locate a company record in the Company table where the Company ID matches the passed id 
            // to this method.
            var company = _context.Companies.FirstOrDefault(m => m.CompanyID == id);
            
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // GET: Companies/Create
        // Returns the Create.cshtml view page from the Company view folder.
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Companies/Create
        // Add a new Company entry to the database and redirect user to Index.cshtml of the Companies view folder.
        [HttpPost]
        public IActionResult Create(Company company)
        {
            if (ModelState.IsValid)
            {
                _context.Add(company);
                _context.SaveChanges();

                // Creating/setting new TempData variable (called action and isSuccessful) that returns success message
                // of newly added Company entry to the database (See _Layout.cshtml page for TempData reference).
                TempData["action"] = company.Name + " has been added.";
                TempData["isSuccessful"] = "Success";

                return RedirectToAction(nameof(Index));
            }
            
            // Creating/setting new TempData variable (called action and isSuccessful) that returns failed message
            // of attempting to add new Company entry to the database (See _Layout.cshtml page for TempData reference).
            TempData["action"] = company.Name + " was not added.";
            TempData["isSuccessful"] = "Failed";

            return View(company);
        }

        // GET: Companies/Edit/5
        // Returns the retrieved company entry from the database to the Edit.cshtml view page that matches the supplied
        // id passed to the method.
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Attempt to locate a company record in the Company table where the Company ID matches the passed id 
            // to this method.
            var company = _context.Companies.Find(id);

            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }

        // POST: Companies/Edit/5
        // If the ModelState is valid, then proceed to update the company entry with the updated values as inserted
        // from the Edit.cshtml view page under the Companies view folder.
        [HttpPost]
        public IActionResult Edit(Company company)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(company);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyExists(company.CompanyID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                // Creating/setting new TempData variable (called action and isSuccessful) that returns success message
                // when updating existing Company entry in the database (See _Layout.cshtml page for TempData reference).
                TempData["action"] = company.Name + " was updated.";
                TempData["isSuccessful"] = "Success";

                return RedirectToAction(nameof(Index));
            }

            // Creating/setting new TempData variable (called action and isSuccessful) that returns success message
            // when updating existing Company entry in the database (See _Layout.cshtml page for TempData reference).
            TempData["action"] = company.Name + " was not updated.";
            TempData["isSuccessful"] = "Failed";

            return View(company);
        }

        // GET: Companies/Delete/5
        // Attempts to retrieve the company entry associated to the passed company ID in order to proceed to delete
        // the entry with the confirmation of the user.
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Attempts to find a matching company entry in the database with the matching CompanyID entry as passed
            // to this method.
            var company = _context.Companies.FirstOrDefault(m => m.CompanyID == id);

            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // POST: Companies/Delete/5
        // Attempts to remove an entry entirely from the database if the company record is found in the database
        // based on matching CompanyID provided and after user clicked on "Delete" to confirm the action.
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Company company)
        {
            // Attempts to remove an entry entirely from the database if the company record is found in the database
            // based on matching CompanyID provided and after user clicked on "Delete" to confirm the action.
            TempData["action"] = company.Name + " was deleted.";
            TempData["isSuccessful"] = "Success";

            _context.Companies.Remove(company);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // Local method to assist with the process of identifying if the company entry exists in the 
        // database based on whether or not the provided CompanyID matches a record in the Company
        // table.
        private bool CompanyExists(int id)
        {
            return _context.Companies.Any(e => e.CompanyID == id);
        }
    }
}
