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
using SAUU.Models;

namespace SAUU.Controllers
{
    public class ModuloController : Controller
    {
        private readonly SAUUContext _context;

        public ModuloController(SAUUContext context)
        {
            _context = context;
        }

        // GET: Modulo
        public async Task<IActionResult> Index()
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Modulo" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            var modulos = _context.Modulo.Select(x => new ModuloViewModel()
            {
                idModulo = x.idModulo,
                nombreModulo = x.nombreModulo,
                rol = _context.Rol.SingleOrDefault(z=> z.idRol==x.idRol).nombreRol
            });
            return View(modulos);
        }

        // GET: Modulo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Modulo" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (id == null)
            {
                return NotFound();
            }

            var modulo = await _context.Modulo
                .FirstOrDefaultAsync(m => m.idModulo == id);
            if (modulo == null)
            {
                return NotFound();
            }

            var modu = new ModuloViewModel();

            modu.idModulo = modulo.idModulo;
            modu.nombreModulo = modulo.nombreModulo;
            modu.rol = _context.Rol.SingleOrDefault(x=> x.idRol == modulo.idRol).nombreRol;


            return View(modu);
        }

        public IActionResult Create()
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Modulo" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            ViewBag.Roles = _context.Rol.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idModulo,nombreModulo,idRol")] Modulo modulo)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Modulo" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (ModelState.IsValid)
            {
                _context.Add(modulo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(modulo);
        }

        // GET: Modulo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Modulo" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (id == null)
            {
                return NotFound();
            }

            var modulo = await _context.Modulo.FindAsync(id);
            if (modulo == null)
            {
                return NotFound();
            }

            ViewBag.Roles = _context.Rol.ToList();
            return View(modulo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idModulo,nombreModulo,idRol")] Modulo modulo)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Modulo" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (id != modulo.idModulo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modulo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModuloExists(modulo.idModulo))
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
            return View(modulo);
        }

        // GET: Modulo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Modulo" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (id == null)
            {
                return NotFound();
            }

            var modulo = await _context.Modulo
                .FirstOrDefaultAsync(m => m.idModulo == id);
            if (modulo == null)
            {
                return NotFound();
            }

            return View(modulo);
        }

        // POST: Modulo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Modulo" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            var modulo = await _context.Modulo.FindAsync(id);
            _context.Modulo.Remove(modulo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModuloExists(int id)
        {
            return _context.Modulo.Any(e => e.idModulo == id);
        }
    }
}
