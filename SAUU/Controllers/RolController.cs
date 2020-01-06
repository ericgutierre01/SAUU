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
    public class RolController : Controller
    {
        private readonly SAUUContext _context;

        public RolController(SAUUContext context)
        {
            _context = context;
        }

        // GET: Rol
        public async Task<IActionResult> Index()
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Rol" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            return View(await _context.Rol.ToListAsync());
        }

        // GET: Rol/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Rol" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            if (id == null)
            {
                return NotFound();
            }

            var rol = await _context.Rol
                .FirstOrDefaultAsync(m => m.idRol == id);
            if (rol == null)
            {
                return NotFound();
            }

            return View(rol);
        }

        // GET: Rol/Create
        public IActionResult Create()
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Rol" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            return View();
        }

        // POST: Rol/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idRol,nombreRol")] Rol rol)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Rol" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            if (ModelState.IsValid)
            {
                _context.Add(rol);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rol);
        }

        // GET: Rol/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Rol" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            if (id == null)
            {
                return NotFound();
            }

            var rol = await _context.Rol.FindAsync(id);
            if (rol == null)
            {
                return NotFound();
            }
            return View(rol);
        }

        // POST: Rol/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idRol,nombreRol")] Rol rol)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Rol" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            if (id != rol.idRol)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rol);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RolExists(rol.idRol))
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
            return View(rol);
        }

        // GET: Rol/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Rol" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            if (id == null)
            {
                return NotFound();
            }

            var rol = await _context.Rol
                .FirstOrDefaultAsync(m => m.idRol == id);
            if (rol == null)
            {
                return NotFound();
            }

            return View(rol);
        }

        // POST: Rol/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Rol" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            } 
            var rol = await _context.Rol.FindAsync(id);
            _context.Rol.Remove(rol);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RolExists(int id)
        {
            return _context.Rol.Any(e => e.idRol == id);
        }
    }
}
