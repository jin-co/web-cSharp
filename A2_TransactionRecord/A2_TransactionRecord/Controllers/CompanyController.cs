using A2_TransactionRecord.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2_TransactionRecord.Controllers
{
    public class CompanyController : Controller
    {
        #region Constructors
        public CompanyController(TransactionContext context)
        {
            this.context = context;
        }
        #endregion

        #region Properties
        private TransactionContext context { get; set; }
        #endregion

        #region Methods
        public IActionResult Index()
        {
            var companies = context.Companies
                .OrderBy(c => c.Name)
                .ToList();
            return View(companies);
        }

        // shows add page with a form to fill in
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Companies = context.Companies.OrderBy(c => c.Name).ToList();
            return View("Edit", new Company());
        }

        // shows edit page with a form to fill in
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Companies = context.Companies.OrderBy(c => c.Name).ToList();
            var company = context.Companies.Find(id);
            return View(company);
        }

        // handles post request from the add or edit page
        // based on whether there is an ID attached
        [HttpPost]
        public IActionResult Edit(Company company)
        {
            if (ModelState.IsValid)
            {
                if (company.CompanyId == 0)
                {
                    context.Companies.Add(company);
                }
                else
                {
                    context.Companies.Update(company);
                }
                context.SaveChanges(); // commit
                TempData["message"] = company.Name + " Save Successful";
                return RedirectToAction("Index", "Company");
            }
            else
            {
                ViewBag.Action = (company.CompanyId == 0) ? "Add" : "Edit";
                TempData["message"] = company.Name + " Save Failed";
                return View(company);
            }
        }

        // shows delete page with a confirm message
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var company = context.Companies.Find(id);
            return View(company);
        }

        // deletes the data selected and show the main page with 
        // chosen data deleted
        [HttpPost]
        public IActionResult Delete(Company company)
        {
            context.Companies.Remove(company);
            context.SaveChanges();
            TempData["message"] = company.Name + " Delete Successful";
            return RedirectToAction("Index", "Home");
        }
        #endregion
    }
}
