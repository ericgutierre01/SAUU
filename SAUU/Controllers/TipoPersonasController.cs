using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SAUU.Data;
using SAUU.Data.Entities;

namespace SAUU.Controllers
{
    public class TipoPersonasController : Controller
    {
        private readonly SAUUContext _context;

        public TipoPersonasController(SAUUContext context)
        {

            _context = context;
        }

        // GET: TipoPersonas
        public async Task<IActionResult> Index()
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "TipoPersonas" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            return View(await _context.TipoPersona.ToListAsync());
        }

        // GET: TipoPersonas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "TipoPersonas" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            if (id == null)
            {
                return NotFound();
            }

            var tipoPersona = await _context.TipoPersona
                .FirstOrDefaultAsync(m => m.idTipoPersona == id);
            if (tipoPersona == null)
            {
                return NotFound();
            }

            return View(tipoPersona);
        }

        // GET: TipoPersonas/Create
        public IActionResult Create()
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "TipoPersonas" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idTipoPersona,nombreTipoPersona")] TipoPersona tipoPersona)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "TipoPersonas" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            if (ModelState.IsValid)
            {
                _context.Add(tipoPersona);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoPersona);
        }

        // GET: TipoPersonas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "TipoPersonas" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            if (id == null)
            {
                return NotFound();
            }

            var tipoPersona = await _context.TipoPersona.FindAsync(id);
            if (tipoPersona == null)
            {
                return NotFound();
            }
            return View(tipoPersona);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idTipoPersona,nombreTipoPersona")] TipoPersona tipoPersona)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "TipoPersonas" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            if (id != tipoPersona.idTipoPersona)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoPersona);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoPersonaExists(tipoPersona.idTipoPersona))
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
            return View(tipoPersona);
        }

        // GET: TipoPersonas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "TipoPersonas" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            if (id == null)
            {
                return NotFound();
            }

            var tipoPersona = await _context.TipoPersona
                .FirstOrDefaultAsync(m => m.idTipoPersona == id);
            if (tipoPersona == null)
            {
                return NotFound();
            }

            return View(tipoPersona);
        }

        // POST: TipoPersonas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "TipoPersonas" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            var tipoPersona = await _context.TipoPersona.FindAsync(id);
            _context.TipoPersona.Remove(tipoPersona);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoPersonaExists(int id)
        {
            return _context.TipoPersona.Any(e => e.idTipoPersona == id);
        }
    }
}
