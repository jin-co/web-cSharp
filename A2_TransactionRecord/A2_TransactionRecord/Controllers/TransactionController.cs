using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using A2_TransactionRecord.Models;

namespace A2_TransactionRecord.Controllers
{
    public class TransactionController : Controller
    {
        private readonly TransactionContext _context;

        public TransactionController(TransactionContext context)
        {
            _context = context;
        }

        // GET: Transaction
        public async Task<IActionResult> Index()
        {
            var transactionContext = _context.TransactionRecordKbaek7943s.Include(t => t.Company).Include(t => t.TransactionType);
            return View(await transactionContext.ToListAsync());
        }

        // GET: Transaction/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionRecordKbaek7943 = await _context.TransactionRecordKbaek7943s
                .Include(t => t.Company)
                .Include(t => t.TransactionType)
                .FirstOrDefaultAsync(m => m.TransactionRecordKbaek7943Id == id);
            if (transactionRecordKbaek7943 == null)
            {
                return NotFound();
            }

            return View(transactionRecordKbaek7943);
        }

        // GET: Transaction/Create
        public IActionResult Create()
        {
            ViewData["CompanyId"] = new SelectList(_context.Companies, "CompanyId", "CompanyId");
            ViewData["TransactionTypeId"] = new SelectList(_context.TransactionTypes, "TransactionTypeId", "TransactionTypeId");
            return View();
        }

        // POST: Transaction/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransactionRecordKbaek7943Id,Quantity,SharePrice,TransactionTypeId,CompanyId")] TransactionRecordKbaek7943 transactionRecordKbaek7943)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transactionRecordKbaek7943);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), "Home");
            }
            ViewData["CompanyId"] = new SelectList(_context.Companies, "CompanyId", "CompanyId", transactionRecordKbaek7943.CompanyId);
            ViewData["TransactionTypeId"] = new SelectList(_context.TransactionTypes, "TransactionTypeId", "TransactionTypeId", transactionRecordKbaek7943.TransactionTypeId);
            return View(transactionRecordKbaek7943);
        }

        // GET: Transaction/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionRecordKbaek7943 = await _context.TransactionRecordKbaek7943s.FindAsync(id);
            if (transactionRecordKbaek7943 == null)
            {
                return NotFound();
            }
            ViewData["CompanyId"] = new SelectList(_context.Companies, "CompanyId", "CompanyId", transactionRecordKbaek7943.CompanyId);
            ViewData["TransactionTypeId"] = new SelectList(_context.TransactionTypes, "TransactionTypeId", "TransactionTypeId", transactionRecordKbaek7943.TransactionTypeId);
            return View(transactionRecordKbaek7943);
        }

        // POST: Transaction/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransactionRecordKbaek7943Id,Quantity,SharePrice,TransactionTypeId,CompanyId")] TransactionRecordKbaek7943 transactionRecordKbaek7943)
        {
            if (id != transactionRecordKbaek7943.TransactionRecordKbaek7943Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transactionRecordKbaek7943);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionRecordKbaek7943Exists(transactionRecordKbaek7943.TransactionRecordKbaek7943Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), "Home");
            }
            ViewData["CompanyId"] = new SelectList(_context.Companies, "CompanyId", "CompanyId", transactionRecordKbaek7943.CompanyId);
            ViewData["TransactionTypeId"] = new SelectList(_context.TransactionTypes, "TransactionTypeId", "TransactionTypeId", transactionRecordKbaek7943.TransactionTypeId);
            return View(transactionRecordKbaek7943);
        }

        // GET: Transaction/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionRecordKbaek7943 = await _context.TransactionRecordKbaek7943s
                .Include(t => t.Company)
                .Include(t => t.TransactionType)
                .FirstOrDefaultAsync(m => m.TransactionRecordKbaek7943Id == id);
            if (transactionRecordKbaek7943 == null)
            {
                return NotFound();
            }

            return View(transactionRecordKbaek7943);
        }

        // POST: Transaction/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transactionRecordKbaek7943 = await _context.TransactionRecordKbaek7943s.FindAsync(id);
            _context.TransactionRecordKbaek7943s.Remove(transactionRecordKbaek7943);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), "Home");
        }

        private bool TransactionRecordKbaek7943Exists(int id)
        {
            return _context.TransactionRecordKbaek7943s.Any(e => e.TransactionRecordKbaek7943Id == id);
        }
    }
}
