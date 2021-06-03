using CovidCare.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidCare.Controllers
{
    public class QuarantineController : Controller
    {
        public IActionResult Quarantine()
        {
            return View();
        }
        private readonly QuarantineContext _context;

        public QuarantineController(QuarantineContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Quarantines.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quarantine = await _context.Quarantines
                .FirstOrDefaultAsync(m => m.Id == id);
            if (quarantine == null)
            {
                return NotFound();
            }

            return View(quarantine);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Quarantine(Quarantine uc)
        {
            _context.Add(uc);
            _context.SaveChanges();
            ViewBag.message = uc.Name + " your Request has been Sent.";
            return View();
        }
        // GET: Registrations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quarantine = await _context.Quarantines.FindAsync(id);
            if (quarantine == null)
            {
                return NotFound();
            }
            return View(quarantine);
        }

        // POST: Registrations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Gender,Age,Email,City,Centres,Beds,Aadhar,Mobile")] Quarantine quarantine)
        {
            if (id != quarantine.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quarantine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuarantineExists(quarantine.Id))
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
            return View(quarantine);
        }

        private bool QuarantineExists(int id)
        {
            throw new NotImplementedException();
        }

        // GET: Registrations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quarantine = await _context.Quarantines.FirstOrDefaultAsync(m => m.Id == id);
            if (quarantine == null)
            {
                return NotFound();
            }

            return View(quarantine);
        }

        // POST: Registrations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registration = await _context.Quarantines.FindAsync(id);
            _context.Quarantines.Remove(registration);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
