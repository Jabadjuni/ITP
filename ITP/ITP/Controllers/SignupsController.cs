using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITP.Data;
using ITP.Models;

namespace ITP.Controllers
{
    public class SignupsController : Controller
    {
        private readonly BaseContext _context;

        public SignupsController(BaseContext context)
        {
            _context = context;
        }

        // GET: Signups
        public async Task<IActionResult> Index()
        {
            return View(await _context.Signups.ToListAsync());
        }

        // GET: Signups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signup = await _context.Signups
                .SingleOrDefaultAsync(m => m.ID == id);
            if (signup == null)
            {
                return NotFound();
            }

            return View(signup);
        }

        // GET: Signups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Signups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Email")] Signup signup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(signup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(signup);
        }

        // GET: Signups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signup = await _context.Signups.SingleOrDefaultAsync(m => m.ID == id);
            if (signup == null)
            {
                return NotFound();
            }
            return View(signup);
        }

        // POST: Signups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Email")] Signup signup)
        {
            if (id != signup.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(signup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SignupExists(signup.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(signup);
        }

        // GET: Signups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signup = await _context.Signups
                .SingleOrDefaultAsync(m => m.ID == id);
            if (signup == null)
            {
                return NotFound();
            }

            return View(signup);
        }

        // POST: Signups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var signup = await _context.Signups.SingleOrDefaultAsync(m => m.ID == id);
            _context.Signups.Remove(signup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SignupExists(int id)
        {
            return _context.Signups.Any(e => e.ID == id);
        }
    }
}
