using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using S5_U2_AC_02.Data;
using S5_U2_AC_02.Models;

namespace S5_U2_AC_02.Controllers
{
    public class modeloesController : Controller
    {
        private readonly S5_U2_AC_02Context _context;

        public modeloesController(S5_U2_AC_02Context context)
        {
            _context = context;
        }

        // GET: modeloes
        public async Task<IActionResult> Index()
        {
              return View(await _context.modelo.ToListAsync());
        }

        // GET: modeloes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.modelo == null)
            {
                return NotFound();
            }

            var modelo = await _context.modelo
                .FirstOrDefaultAsync(m => m.ID == id);
            if (modelo == null)
            {
                return NotFound();
            }

            return View(modelo);
        }

        // GET: modeloes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: modeloes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nombre,Salario")] modelo modelo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(modelo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(modelo);
        }

        // GET: modeloes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.modelo == null)
            {
                return NotFound();
            }

            var modelo = await _context.modelo.FindAsync(id);
            if (modelo == null)
            {
                return NotFound();
            }
            return View(modelo);
        }

        // POST: modeloes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nombre,Salario")] modelo modelo)
        {
            if (id != modelo.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modelo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!modeloExists(modelo.ID))
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
            return View(modelo);
        }

        // GET: modeloes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.modelo == null)
            {
                return NotFound();
            }

            var modelo = await _context.modelo
                .FirstOrDefaultAsync(m => m.ID == id);
            if (modelo == null)
            {
                return NotFound();
            }

            return View(modelo);
        }

        // POST: modeloes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.modelo == null)
            {
                return Problem("Entity set 'S5_U2_AC_02Context.modelo'  is null.");
            }
            var modelo = await _context.modelo.FindAsync(id);
            if (modelo != null)
            {
                _context.modelo.Remove(modelo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool modeloExists(int id)
        {
          return _context.modelo.Any(e => e.ID == id);
        }
    }
}
