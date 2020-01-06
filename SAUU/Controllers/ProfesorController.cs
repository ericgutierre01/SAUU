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
    public class ProfesorController : Controller
    {
        private readonly SAUUContext _context;

        public ProfesorController(SAUUContext context)
        {
            _context = context;
        }

        // GET: Profesor
        public async Task<IActionResult> Index()
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Profesor" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            return View(await _context.Profesores.ToListAsync());
        }

        // GET: Profesor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Profesor" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (id == null)
            {
                return NotFound();
            }

            var profesor = await _context.Profesores
                .FirstOrDefaultAsync(m => m.idProfesor == id);
            if (profesor == null)
            {
                return NotFound();
            }

            return View(profesor);
        }

        // GET: Profesor/Create
        public IActionResult Create()
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Profesor" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            ViewBag.Persona = _context.Persona.Select(x => new Persona()
            {
                idPersona = x.idPersona,
                nombrePersona = x.nombrePersona + " " + x.apellidoPersona
            });
            return View();
        }

        // POST: Profesor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idProfesor,identificadorProfesor,idPersona")] Profesor profesor)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Profesor" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (ModelState.IsValid)
            {
                _context.Add(profesor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(profesor);
        }

        // GET: Profesor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Profesor" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Persona = _context.Persona.Select(x => new Persona()
            {
                idPersona = x.idPersona,
                nombrePersona = x.nombrePersona + " " + x.apellidoPersona
            });
            var profesor = await _context.Profesores.FindAsync(id);
            if (profesor == null)
            {
                return NotFound();
            }
            return View(profesor);
        }

        // POST: Profesor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idProfesor,identificadorProfesor,idPersona")] Profesor profesor)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Profesor" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (id != profesor.idProfesor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (!_context.Modulo.Any(x => x.nombreModulo == "Profesor" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
                {
                    return Redirect("../");
                    //return RedirectToAction("DetailResponder");
                }
                try
                {
                    _context.Update(profesor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfesorExists(profesor.idProfesor))
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
            ViewBag.Persona = _context.Persona.Select(x => new Persona()
            {
                idPersona = x.idPersona,
                nombrePersona = x.nombrePersona + " " + x.apellidoPersona
            });
            return View(profesor);
        }

        // GET: Profesor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Profesor" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (id == null)
            {
                return NotFound();
            }

            var profesor = await _context.Profesores
                .FirstOrDefaultAsync(m => m.idProfesor == id);
            if (profesor == null)
            {
                return NotFound();
            }

            return View(profesor);
        }

        // POST: Profesor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Profesor" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            var profesor = await _context.Profesores.FindAsync(id);
            _context.Profesores.Remove(profesor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfesorExists(int id)
        {
            return _context.Profesores.Any(e => e.idProfesor == id);
        }

        [HttpGet]
        public JsonResult GetPersoJson(int Id)
        {

            var persona = _context.Persona.SingleOrDefault(x=>x.idPersona == Id);
            return Json(persona);
        }
    }
}
