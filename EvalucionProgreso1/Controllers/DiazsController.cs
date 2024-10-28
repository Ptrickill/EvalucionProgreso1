using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EvalucionProgreso1.Models;

namespace EvalucionProgreso1.Controllers
{
    public class DiazsController : Controller
    {
        private readonly Daniel_Diaz_Progreso_1 _context;

        public DiazsController(Daniel_Diaz_Progreso_1 context)
        {
            _context = context;
        }

        // GET: Diazs
        public async Task<IActionResult> Index()
        {
            var daniel_Diaz_Progreso_1 = _context.Diaz.Include(d => d.Celular);
            return View(await daniel_Diaz_Progreso_1.ToListAsync());
        }

        // GET: Diazs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diaz = await _context.Diaz
                .Include(d => d.Celular)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diaz == null)
            {
                return NotFound();
            }

            return View(diaz);
        }

        // GET: Diazs/Create
        public IActionResult Create()
        {
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "IdCelular", "Modelo");
            return View();
        }

        // POST: Diazs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AtributoDecimal,NombreCompleto,Fecha,TieneBeca,IdCelular")] Diaz diaz)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diaz);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "IdCelular", "Modelo", diaz.IdCelular);
            return View(diaz);
        }

        // GET: Diazs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diaz = await _context.Diaz.FindAsync(id);
            if (diaz == null)
            {
                return NotFound();
            }
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "IdCelular", "Modelo", diaz.IdCelular);
            return View(diaz);
        }

        // POST: Diazs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AtributoDecimal,NombreCompleto,Fecha,TieneBeca,IdCelular")] Diaz diaz)
        {
            if (id != diaz.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diaz);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiazExists(diaz.Id))
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
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "IdCelular", "Modelo", diaz.IdCelular);
            return View(diaz);
        }

        // GET: Diazs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diaz = await _context.Diaz
                .Include(d => d.Celular)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diaz == null)
            {
                return NotFound();
            }

            return View(diaz);
        }

        // POST: Diazs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diaz = await _context.Diaz.FindAsync(id);
            if (diaz != null)
            {
                _context.Diaz.Remove(diaz);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiazExists(int id)
        {
            return _context.Diaz.Any(e => e.Id == id);
        }
    }
}
