using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using konjac_sponges.Data;
using konjac_sponges.Models;
// File: SpongeClassesController.cs
// Author Name: Het Natvarbhai Patel
// Student i'd: 0805024

namespace konjac_sponges.Controllers
{
    public class SpongeClassesController : Controller
    {
        private readonly konjac_spongesContext _context;

        public SpongeClassesController(konjac_spongesContext context)
        {
            _context = context;
        }

        // GET: SpongeClasses
        public async Task<IActionResult> Index()
        {
            return View(await _context.SpongeClass.ToListAsync());
        }

        // GET: SpongeClasses/Details/5
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

        // GET: SpongeClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SpongeClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ProductName,Price,SpongeSize,Color")] SpongeClass spongeClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(spongeClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(spongeClass);
        }

        // GET: SpongeClasses/Edit/5
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

        // POST: SpongeClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ProductName,Price,SpongeSize,Color")] SpongeClass spongeClass)
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

        // GET: SpongeClasses/Delete/5
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

        // POST: SpongeClasses/Delete/5
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
