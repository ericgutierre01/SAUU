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
    public class EstadoController : Controller
    {
        private readonly SAUUContext _context;

        public EstadoController(SAUUContext context)
        {
            _context = context;
        }

        // GET: Estado
        public async Task<IActionResult> Index()
        {
            if (!_context.Modulo.Any(x=>x.nombreModulo == "Estado" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            return View(await _context.Estados.ToListAsync());
        }

        // GET: Estado/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Estado" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (id == null)
            {
                return NotFound();
            }

            var estado = await _context.Estados
                .FirstOrDefaultAsync(m => m.idEstado == id);
            if (estado == null)
            {
                return NotFound();
            }

            return View(estado);
        }

        // GET: Estado/Create
        [Route("Estado/Nuevo")]
        public IActionResult Create()
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Estado" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            return View();
        }

        [HttpPost]
        [Route("Estado/Nuevo")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idEstado,nombreEstado,colorEstado")] Estado estado)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Estado" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (ModelState.IsValid)
            {
                _context.Add(estado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estado);
        }

        // GET: Estado/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Estado" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (id == null)
            {
                return NotFound();
            }

            var estado = await _context.Estados.FindAsync(id);
            if (estado == null)
            {
                return NotFound();
            }
            return View(estado);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idEstado,nombreEstado,colorEstado")] Estado estado)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Estado" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            if (id != estado.idEstado)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadoExists(estado.idEstado))
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
            return View(estado);
        }

        // GET: Estado/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Estado" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            if (id == null)
            {
                return NotFound();
            }

            var estado = await _context.Estados
                .FirstOrDefaultAsync(m => m.idEstado == id);
            if (estado == null)
            {
                return NotFound();
            }

            return View(estado);
        }

        // POST: Estado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Estado" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            var estado = await _context.Estados.FindAsync(id);
            _context.Estados.Remove(estado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstadoExists(int id)
        {
            return _context.Estados.Any(e => e.idEstado == id);
        }
    }
}
