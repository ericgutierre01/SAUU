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
    public class EscuelaController : Controller
    {
        private readonly SAUUContext _context;

        public EscuelaController(SAUUContext context)
        {
            _context = context;
        }

        // GET: Escuela
        public async Task<IActionResult> Index()
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Escuela" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }

            var mode = _context.Escuela.Select(x => new EscuelaViewModel()
            {
                idEscuela = x.idEscuela,
                idFacultad = x.idFacultad,
                nombreEscuela = x.nombreEscuela,
                nombreFacultad = _context.Facultad.SingleOrDefault(y => y.idFacultad== x.idFacultad).nombreFacultad,
                correo = x.correo
            });
            return View(mode);
        }

        // GET: Escuela/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Escuela" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }

            if (id == null)
            {
                return NotFound();
            }

            var escuela = await _context.Escuela
                .FirstOrDefaultAsync(m => m.idEscuela == id);
            var mode = new EscuelaViewModel()
            {
                idEscuela = escuela.idEscuela,
                idFacultad = escuela.idFacultad,
                correo = escuela.correo,
                nombreEscuela = escuela.nombreEscuela,
                nombreFacultad = _context.Facultad.SingleOrDefault(y => y.idFacultad == escuela.idFacultad).nombreFacultad,

            };
 
            if (escuela == null)
            {
                return NotFound();
            }

            return View(mode);
        }

        // GET: Escuela/Create
        public IActionResult Create()
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Escuela" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            ViewBag.Facultades = _context.Facultad.Select(x => new Facultad()
            {
                idFacultad = x.idFacultad,
                nombreFacultad = x.nombreFacultad
            });
            return View();
        }

        // POST: Escuela/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idEscuela,nombreEscuela,idFacultad")] Escuela escuela)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Escuela" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }

            if (ModelState.IsValid)
            {
                _context.Add(escuela);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(escuela);
        }

        // GET: Escuela/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Escuela" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }

            if (id == null)
            {
                return NotFound();
            }

            ViewBag.Facultades = _context.Facultad.Select(x => new Facultad()
            {
                idFacultad = x.idFacultad,
                nombreFacultad = x.nombreFacultad
            });
            var escuela = await _context.Escuela.FindAsync(id);
            if (escuela == null)
            {
                return NotFound();
            }
            return View(escuela);
        }

        // POST: Escuela/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idEscuela,nombreEscuela,idFacultad")] Escuela escuela)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Escuela" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }

            if (id != escuela.idEscuela)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(escuela);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EscuelaExists(escuela.idEscuela))
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
            return View(escuela);
        }

        // GET: Escuela/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Escuela" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (id == null)
            {
                return NotFound();
            }

            var escuela = await _context.Escuela
                .FirstOrDefaultAsync(m => m.idEscuela == id);

            var mode = new EscuelaViewModel()
            {
                idEscuela = escuela.idEscuela,
                idFacultad = escuela.idFacultad,
                correo = escuela.correo,
                nombreEscuela = escuela.nombreEscuela,
                nombreFacultad = _context.Facultad.SingleOrDefault(y => y.idFacultad == escuela.idFacultad).nombreFacultad,

            };

            if (escuela == null)
            {
                return NotFound();
            }

            return View(mode);
        }

        // POST: Escuela/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Escuela" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            var escuela = await _context.Escuela.FindAsync(id);
            _context.Escuela.Remove(escuela);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EscuelaExists(int id)
        {
            return _context.Escuela.Any(e => e.idEscuela == id);
        }
    }
}
