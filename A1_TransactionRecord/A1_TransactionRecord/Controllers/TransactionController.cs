using A1_TransactionRecord.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A1_TransactionRecord.Controllers
{
    // Controller that handles request related to transaction records
    public class TransactionController : Controller
    {
        #region Constructors
        public TransactionController(TransactionContext context)
        {
            this.context = context;
        }
        #endregion

        #region Properties
        private TransactionContext context { get; set; }
        #endregion

        #region Methods
        // shows add page with a form to fill in
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.TransactionTypes = context.TransactionTypes.OrderBy(t => t.Name).ToList();
            return View("Edit", new TransactionRecordKbaek7943());
        }

        // shows edit page with a form to fill in
        [HttpGet]
        public IActionResult Edit(int transactionId)
        {
            ViewBag.Action = "Edit";
            ViewBag.TransactionTypes = context.TransactionTypes.OrderBy(t => t.Name).ToList();
            var transaction = context.TransactionRecordKbaek7943s.Find(transactionId);
            return View(transaction);
        }
        
        // handles post request from the add or edit page
        // based on whether there is an ID attached
        [HttpPost]
        public IActionResult Edit(TransactionRecordKbaek7943 transaction)
        {
            if (ModelState.IsValid)
            {
                if (transaction.TransactionRecordKbaek7943Id == 0)
                {
                    context.TransactionRecordKbaek7943s.Add(transaction);
                }
                else
                {
                    context.TransactionRecordKbaek7943s.Update(transaction);
                }
                context.SaveChanges(); // commit
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (transaction.TransactionRecordKbaek7943Id == 0) ? "Add" : "Edit";
                ViewBag.TransactionTypes = context.TransactionTypes.OrderBy(t => t.Name).ToList();
                return View(transaction);
            }
        }

        // shows delete page with a confirm message
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var transaction = context.TransactionRecordKbaek7943s.Find(id);
            return View(transaction);
        }
        
        // deletes the data selected and show the main page with 
        // chosen data deleted
        [HttpPost]
        public IActionResult Delete(TransactionRecordKbaek7943 transaction)
        {
            context.TransactionRecordKbaek7943s.Remove(transaction);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        #endregion
    }
}
