using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IntroductionToAspMVC;
using IntroductionToAspMVC.Models;

namespace IntroductionToAspMVC.Controllers
{
    public class CarpetsController : Controller
    {
        private readonly AspContext _context;

        public CarpetsController(AspContext context)
        {
            _context = context;
        }

        // GET: Carpets
        public async Task<IActionResult> Index()
        {
            return View(await _context.Carpet.ToListAsync());
        }

        // GET: Carpets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carpet = await _context.Carpet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carpet == null)
            {
                return NotFound();
            }

            return View(carpet);
        }

        // GET: Carpets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carpets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Texture,Material,SizeSquared,IsHypoAllergic,Price,Id")] Carpet carpet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carpet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carpet);
        }

        // GET: Carpets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carpet = await _context.Carpet.FindAsync(id);
            if (carpet == null)
            {
                return NotFound();
            }
            return View(carpet);
        }

        // POST: Carpets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Texture,IsHypoAllergic,Price,Id")] Carpet carpet)
        {
            if (id != carpet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carpet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarpetExists(carpet.Id))
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
            return View(carpet);
        }

        // GET: Carpets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carpet = await _context.Carpet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carpet == null)
            {
                return NotFound();
            }

            return View(carpet);
        }

        // POST: Carpets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carpet = await _context.Carpet.FindAsync(id);
            _context.Carpet.Remove(carpet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarpetExists(int id)
        {
            return _context.Carpet.Any(e => e.Id == id);
        }
    }
}
