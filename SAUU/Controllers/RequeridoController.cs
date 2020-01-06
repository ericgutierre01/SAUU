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
    public class RequeridoController : Controller
    {
        private readonly SAUUContext _context;

        public RequeridoController(SAUUContext context)
        {
            _context = context;
        }

        // GET: Requerido
        public async Task<IActionResult> Index()
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Requerido" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            return View(await _context.Requeridos.ToListAsync());
        }

        // GET: Requerido/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Requerido" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (id == null)
            {
                return NotFound();
            }

            var requerido = await _context.Requeridos
                .FirstOrDefaultAsync(m => m.idRequerido == id);
            if (requerido == null)
            {
                return NotFound();
            }

            return View(requerido);
        }

        // GET: Requerido/Create
        public IActionResult Create()
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Requerido" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            return View();
        }

        // POST: Requerido/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idRequerido,nombreRequerido")] Requerido requerido)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Requerido" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (ModelState.IsValid)
            {
                _context.Add(requerido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(requerido);
        }

        // GET: Requerido/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Requerido" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (id == null)
            {
                return NotFound();
            }

            var requerido = await _context.Requeridos.FindAsync(id);
            if (requerido == null)
            {
                return NotFound();
            }
            return View(requerido);
        }

        // POST: Requerido/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idRequerido,nombreRequerido")] Requerido requerido)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Requerido" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (id != requerido.idRequerido)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requerido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequeridoExists(requerido.idRequerido))
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
            return View(requerido);
        }

        // GET: Requerido/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Requerido" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (id == null)
            {
                return NotFound();
            }

            var requerido = await _context.Requeridos
                .FirstOrDefaultAsync(m => m.idRequerido == id);
            if (requerido == null)
            {
                return NotFound();
            }

            return View(requerido);
        }

        // POST: Requerido/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Requerido" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            var requerido = await _context.Requeridos.FindAsync(id);
            _context.Requeridos.Remove(requerido);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequeridoExists(int id)
        {
            return _context.Requeridos.Any(e => e.idRequerido == id);
        }
    }
}
