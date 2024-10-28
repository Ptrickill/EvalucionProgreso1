﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EvalucionProgreso1.Models;

namespace EvalucionProgreso1.Controllers
{
    public class CelularsController : Controller
    {
        private readonly Daniel_Diaz_Progreso_1 _context;

        public CelularsController(Daniel_Diaz_Progreso_1 context)
        {
            _context = context;
        }

        // GET: Celulars
        public async Task<IActionResult> Index()
        {
            var daniel_Diaz_Progreso_1 = _context.Celular.Include(c => c.Diaz);
            return View(await daniel_Diaz_Progreso_1.ToListAsync());
        }

        // GET: Celulars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var celular = await _context.Celular
                .Include(c => c.Diaz)
                .FirstOrDefaultAsync(m => m.IdCelular == id);
            if (celular == null)
            {
                return NotFound();
            }

            return View(celular);
        }

        // GET: Celulars/Create
        public IActionResult Create()
        {
            ViewData["Id"] = new SelectList(_context.Diaz, "Id", "NombreCompleto");
            return View();
        }

        // POST: Celulars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCelular,Modelo,Año,Precio,Id")] Celular celular)
        {
            if (ModelState.IsValid)
            {
                _context.Add(celular);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id"] = new SelectList(_context.Diaz, "Id", "NombreCompleto", celular.Id);
            return View(celular);
        }

        // GET: Celulars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var celular = await _context.Celular.FindAsync(id);
            if (celular == null)
            {
                return NotFound();
            }
            ViewData["Id"] = new SelectList(_context.Diaz, "Id", "NombreCompleto", celular.Id);
            return View(celular);
        }

        // POST: Celulars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCelular,Modelo,Año,Precio,Id")] Celular celular)
        {
            if (id != celular.IdCelular)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(celular);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CelularExists(celular.IdCelular))
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
            ViewData["Id"] = new SelectList(_context.Diaz, "Id", "NombreCompleto", celular.Id);
            return View(celular);
        }

        // GET: Celulars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var celular = await _context.Celular
                .Include(c => c.Diaz)
                .FirstOrDefaultAsync(m => m.IdCelular == id);
            if (celular == null)
            {
                return NotFound();
            }

            return View(celular);
        }

        // POST: Celulars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var celular = await _context.Celular.FindAsync(id);
            if (celular != null)
            {
                _context.Celular.Remove(celular);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CelularExists(int id)
        {
            return _context.Celular.Any(e => e.IdCelular == id);
        }
    }
}
