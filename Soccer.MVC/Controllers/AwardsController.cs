

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Soccer.MVC.Data;
using Soccer.MVC.Models;

namespace Soccer.MVC.Controllers
{
    public class AwardsController : Controller
    {
        private readonly SoccerMVCContext _context;

        public AwardsController(SoccerMVCContext context)
        {
            _context = context;
        }

        // GET: Awards1
        public async Task<IActionResult> Index()
        {
              return _context.Award != null ? 
                          View(await _context.Award.ToListAsync()) :
                          Problem("Entity set 'SoccerMVCContext.Award'  is null.");
        }

        // GET: Awards1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Award == null)
            {
                return NotFound();
            }

            var award = await _context.Award
                .FirstOrDefaultAsync(m => m.ID == id);
            if (award == null)
            {
                return NotFound();
            }

            return View(award);
        }

        // GET: Awards1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Awards1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description,Category")] Award award)
        {
            if (ModelState.IsValid)
            {
                _context.Add(award);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(award);
        }

        // GET: Awards1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Award == null)
            {
                return NotFound();
            }

            var award = await _context.Award.FindAsync(id);
            if (award == null)
            {
                return NotFound();
            }
            return View(award);
        }

        // POST: Awards1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description,Category")] Award award)
        {
            if (id != award.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(award);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!
                        
                        AwardExists(award.ID))
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
            return View(award);
        }

        // GET: Awards1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Award == null)
            {
                return NotFound();
            }

            var award = await _context.Award
                .FirstOrDefaultAsync(m => m.ID == id);
            if (award == null)
            {
                return NotFound();
            }

            return View(award);
        }

        // POST: Awards1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Award == null)
            {
                return Problem("Entity set 'SoccerMVCContext.Award'  is null.");
            }
            var award = await _context.Award.FindAsync(id);
            if (award != null)
            {
                _context.Award.Remove(award);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AwardExists(int id)
        {
          return (_context.Award?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
