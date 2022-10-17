using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using konjac_sponges.Data;
using konjac_sponges.Models;

namespace konjac_sponges.Controllers
{
    public class SpongeClasses1Controller : Controller
    {
        private readonly konjac_spongesContext _context;

        public SpongeClasses1Controller(konjac_spongesContext context)
        {
            _context = context;
        }

        // GET: SpongeClasses1
        public async Task<IActionResult> Index()
        {
            return View(await _context.SpongeClass.ToListAsync());
        }

        // GET: SpongeClasses1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spongeClass = await _context.SpongeClass
                .FirstOrDefaultAsync(m => m.ID == id);
            if (spongeClass == null)
            {
                return NotFound();
            }

            return View(spongeClass);
        }

        // GET: SpongeClasses1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SpongeClasses1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ProductName,Price,SpongeSize,Color,Shape,Review")] SpongeClass spongeClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(spongeClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(spongeClass);
        }

        // GET: SpongeClasses1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spongeClass = await _context.SpongeClass.FindAsync(id);
            if (spongeClass == null)
            {
                return NotFound();
            }
            return View(spongeClass);
        }

        // POST: SpongeClasses1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ProductName,Price,SpongeSize,Color,Shape,Review")] SpongeClass spongeClass)
        {
            if (id != spongeClass.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(spongeClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpongeClassExists(spongeClass.ID))
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
            return View(spongeClass);
        }

        // GET: SpongeClasses1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spongeClass = await _context.SpongeClass
                .FirstOrDefaultAsync(m => m.ID == id);
            if (spongeClass == null)
            {
                return NotFound();
            }

            return View(spongeClass);
        }

        // POST: SpongeClasses1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var spongeClass = await _context.SpongeClass.FindAsync(id);
            _context.SpongeClass.Remove(spongeClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpongeClassExists(int id)
        {
            return _context.SpongeClass.Any(e => e.ID == id);
        }
    }
}
