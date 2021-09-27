using A1_TransactionRecord.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A1_TransactionRecord.Controllers
{
    public class TransactionController : Controller
    {
        public TransactionController(TransactionContext context)
        {
            this.context = context;
        }

        private TransactionContext context { get; set; }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new TransactionRecordKbaek7943());
        }

        [HttpGet]
        public IActionResult Edit(int transactionId)
        {
            ViewBag.Action = "Edit";
            var transaction = context.TransactionRecordKbaek7943s.Find(transactionId);
            return View(transaction);
        }
        
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
                return View(transaction);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var transaction = context.TransactionRecordKbaek7943s.Find(id);
            return View(transaction);
        }
        
        [HttpPost]
        public IActionResult Delete(TransactionRecordKbaek7943 transaction)
        {
            context.TransactionRecordKbaek7943s.Remove(transaction);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
