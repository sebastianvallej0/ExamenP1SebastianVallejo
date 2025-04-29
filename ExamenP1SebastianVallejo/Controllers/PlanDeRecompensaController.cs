using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExamenP1SebastianVallejo.Models;

namespace ExamenP1SebastianVallejo.Controllers
{
    public class PlanDeRecompensaController : Controller
    {
        private readonly DBSqlSERVER_ExamenP1SebastianVallejo _context;

        public PlanDeRecompensaController(DBSqlSERVER_ExamenP1SebastianVallejo context)
        {
            _context = context;
        }

        // GET: PlanDeRecompensa
        public async Task<IActionResult> Index()
        {
            var dBSqlSERVER_ExamenP1SebastianVallejo = _context.PlanDeRecompensas.Include(p => p.Cliente);
            return View(await dBSqlSERVER_ExamenP1SebastianVallejo.ToListAsync());
        }

        // GET: PlanDeRecompensa/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planDeRecompensas = await _context.PlanDeRecompensas
                .Include(p => p.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planDeRecompensas == null)
            {
                return NotFound();
            }

            return View(planDeRecompensas);
        }

        // GET: PlanDeRecompensa/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Id");
            return View();
        }

        // POST: PlanDeRecompensa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,FechaInicio,PuntosAcumulados,TipoRecompensa,ClienteId")] PlanDeRecompensas planDeRecompensas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planDeRecompensas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Id", planDeRecompensas.ClienteId);
            return View(planDeRecompensas);
        }

        // GET: PlanDeRecompensa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planDeRecompensas = await _context.PlanDeRecompensas.FindAsync(id);
            if (planDeRecompensas == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Id", planDeRecompensas.ClienteId);
            return View(planDeRecompensas);
        }

        // POST: PlanDeRecompensa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,FechaInicio,PuntosAcumulados,TipoRecompensa,ClienteId")] PlanDeRecompensas planDeRecompensas)
        {
            if (id != planDeRecompensas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planDeRecompensas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanDeRecompensasExists(planDeRecompensas.Id))
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
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Id", planDeRecompensas.ClienteId);
            return View(planDeRecompensas);
        }

        // GET: PlanDeRecompensa/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planDeRecompensas = await _context.PlanDeRecompensas
                .Include(p => p.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planDeRecompensas == null)
            {
                return NotFound();
            }

            return View(planDeRecompensas);
        }

        // POST: PlanDeRecompensa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planDeRecompensas = await _context.PlanDeRecompensas.FindAsync(id);
            if (planDeRecompensas != null)
            {
                _context.PlanDeRecompensas.Remove(planDeRecompensas);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanDeRecompensasExists(int id)
        {
            return _context.PlanDeRecompensas.Any(e => e.Id == id);
        }
    }
}
