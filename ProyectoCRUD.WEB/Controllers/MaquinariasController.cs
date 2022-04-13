using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoCRUD.WEB.Models.DAL;
using ProyectoCRUD.WEB.Models.Entities;

namespace ProyectoCRUD.WEB.Controllers
{
    public class MaquinariasController : Controller
    {
        private readonly AppDbContext _context;

        public MaquinariasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Maquinarias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Maquinas.ToListAsync());
        }

        // GET: Maquinarias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maquinaria = await _context.Maquinas
                .FirstOrDefaultAsync(m => m.IdMaquina == id);
            if (maquinaria == null)
            {
                return NotFound();
            }

            return View(maquinaria);
        }

        // GET: Maquinarias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Maquinarias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMaquina,Nombre,Marca,Componentes,Descripcion,Voltaje,Potencia,Amperaje,Velocidad,ProtectorTermico,CajaReductora,Ubicacion")] Maquinaria maquinaria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(maquinaria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(maquinaria);
        }

        // GET: Maquinarias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maquinaria = await _context.Maquinas.FindAsync(id);
            if (maquinaria == null)
            {
                return NotFound();
            }
            return View(maquinaria);
        }

        // POST: Maquinarias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMaquina,Nombre,Marca,Componentes,Descripcion,Voltaje,Potencia,Amperaje,Velocidad,ProtectorTermico,CajaReductora,Ubicacion")] Maquinaria maquinaria)
        {
            if (id != maquinaria.IdMaquina)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maquinaria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaquinariaExists(maquinaria.IdMaquina))
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
            return View(maquinaria);
        }

        // GET: Maquinarias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maquinaria = await _context.Maquinas
                .FirstOrDefaultAsync(m => m.IdMaquina == id);
            if (maquinaria == null)
            {
                return NotFound();
            }

            return View(maquinaria);
        }

        // POST: Maquinarias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var maquinaria = await _context.Maquinas.FindAsync(id);
            _context.Maquinas.Remove(maquinaria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaquinariaExists(int id)
        {
            return _context.Maquinas.Any(e => e.IdMaquina == id);
        }
    }
}
