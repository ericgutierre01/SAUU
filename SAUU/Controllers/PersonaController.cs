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
    public class PersonaController : Controller
    {
        private readonly SAUUContext _context;

        public PersonaController(SAUUContext context)
        {
            _context = context;
        }

        // GET: Persona
        public  IActionResult Index()
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Persona" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            var mode = _context.Persona.Select(x => new PersonaViewModel()
            {
                idTipoPersona = x.idTipoPersona,
                idPersona = x.idPersona,
                nombrePersona = x.nombrePersona,
                apellidoPersona = x.apellidoPersona,
                direccionPersona = x.direccionPersona,
                telefono = x.telefono,
                correo = x.correo,
                stringTipoPersona = _context.TipoPersona.SingleOrDefault(y => y.idTipoPersona == x.idTipoPersona).nombreTipoPersona
            });
            return View(mode);
        }

        // GET: Persona/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Persona" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (id == null)
                {
                    return NotFound();
                }
          
                var persona = await _context.Persona
                    .FirstOrDefaultAsync(m => m.idPersona == id);

                var modelC = new PersonaCompletaViewModel()
                {
                    idTipoPersona = persona.idTipoPersona,
                    idPersona = persona.idPersona,
                    nombrePersona = persona.nombrePersona,
                    apellidoPersona = persona.apellidoPersona,
                    direccionPersona = persona.direccionPersona,
                    telefono = persona.telefono,
                    correo = persona.correo,
                    cedulaPersona = persona.cedulaPersona,
                    fechaNacimiento = persona.fechaNacimiento,
                    stringTipoPersona = _context.TipoPersona.SingleOrDefault(y => y.idTipoPersona == persona.idTipoPersona).nombreTipoPersona
                };

                if (_context.TipoPersona.SingleOrDefault(s => s.idTipoPersona == persona.idTipoPersona).nombreTipoPersona == "Estudiante")
                {
                    modelC.estudiante = _context.Estudiantes.SingleOrDefault(x => x.idPersona == persona.idPersona);
                }
                else
                {
                    modelC.profesor= _context.Profesores.SingleOrDefault(x => x.idPersona == persona.idPersona);
                }

                if (persona == null)
                {
                    return NotFound();
                }

            return View(modelC);

        }

        [Route("Persona/Nuevo")]
        // GET: Persona/Create
        public IActionResult Create()
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Persona" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            ViewBag.TipoPersona = _context.TipoPersona.Select(x => new TipoPersona()
            {
                idTipoPersona = x.idTipoPersona,
                nombreTipoPersona = x.nombreTipoPersona
            });
            return View();
        }

        // POST: Persona/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("Persona/Nuevo")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Persona persona)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Persona" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (ModelState.IsValid)
            {
                _context.Add(persona);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.TipoPersona = _context.TipoPersona.Select(x => new TipoPersona()
            {
                idTipoPersona = x.idTipoPersona,
                nombreTipoPersona = x.nombreTipoPersona
            });
            return View(persona);
        }

        // GET: Persona/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Persona" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.TipoPersona = _context.TipoPersona.Select(x => new TipoPersona()
            {
                idTipoPersona = x.idTipoPersona,
                nombreTipoPersona = x.nombreTipoPersona
            });

            var persona = await _context.Persona.FindAsync(id);
            if (persona == null)
            {
                return NotFound();
            }
            return View(persona);
        }

        // POST: Persona/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit( Persona persona)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Persona" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(persona);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonaExists(persona.idPersona))
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
            return View(persona);
        }

        // GET: Persona/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Persona" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Persona
                .FirstOrDefaultAsync(m => m.idPersona == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // POST: Persona/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Persona" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
                //return RedirectToAction("DetailResponder");
            }
            var persona = await _context.Persona.FindAsync(id);
            _context.Persona.Remove(persona);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonaExists(int id)
        {
            return _context.Persona.Any(e => e.idPersona == id);
        }


    }
}
