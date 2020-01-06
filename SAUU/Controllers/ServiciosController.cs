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
    public class ServiciosController : Controller
    {
        private readonly SAUUContext _context;

        public ServiciosController(SAUUContext context)
        {
            _context = context;
        }

       /* private IActionResult isRol()
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Servicios" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../../");
                //return RedirectToAction("DetailResponder");
            }
            return null;
        }*/
        // GET: Servicios
        public async Task<IActionResult> Index()
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Servicios" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }

            return View(_context.Servicios.Select(x => new ServiciosViewModel()
            {
                idServicio = x.idServicio,
                nombreServicio = x.nombreServicio,
                idEscuela = x.idEscuela,
                prioridad = x.prioridad,
                stringTipoPersona = _context.TipoPersona.SingleOrDefault(y => y.idTipoPersona == x.idTipoPersona).nombreTipoPersona,
                idTipoPersona = x.idTipoPersona,
                nombreEscuela = _context.Escuela.SingleOrDefault(z => z.idEscuela == x.idEscuela).nombreEscuela

            }));
        }

        // GET: Servicios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Servicios" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            if (id == null)
            {
                return NotFound();
            }

            var servicio = await _context.Servicios
                .FirstOrDefaultAsync(m => m.idServicio == id);
            var modelo = new ServiciosViewModel();

            modelo.idServicio = servicio.idServicio;
            modelo.nombreServicio = servicio.nombreServicio;
            modelo.idEscuela = servicio.idEscuela;
            modelo.prioridad = servicio.prioridad;
            modelo.stringTipoPersona = _context.TipoPersona.SingleOrDefault(y => y.idTipoPersona == servicio.idTipoPersona).nombreTipoPersona;
            modelo.idTipoPersona = servicio.idTipoPersona;
            modelo.nombreEscuela = _context.Escuela.SingleOrDefault(z => z.idEscuela == servicio.idEscuela).nombreEscuela;

            if (servicio == null)
            {
                return NotFound();
            }

            return View(modelo);
        }

        // GET: Servicios/Create
        [Route("Servicios/Nuevo")]
        public IActionResult Create()
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Servicios" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }

            ViewBag.Escuelas = _context.Escuela.ToList();
            ViewBag.TipoPersonas = _context.TipoPersona.ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Servicios/Nuevo")]
        public async Task<IActionResult> Create([Bind("idServicio,nombreServicio,idEscuela,prioridad,idTipoPersona")] Servicio servicio, List<string> usr)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Servicios" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }

            if (!ModelState.IsValid)
                throw new Exception("Debes llenar todos los campo!.");

            try
            {
                _context.Servicios.Add(servicio);
                await _context.SaveChangesAsync();

                if (usr.Count > 0)
                {
                    foreach(string reque in usr)
                    {
                        _context.RequeridosServicio.Add(new RequeridosServicio()
                        {
                            idServicio = servicio.idServicio,
                            idRequerido = _context.Requeridos.SingleOrDefault(x => x.nombreRequerido == reque).idRequerido
                        });
                    }

                }
                await _context.SaveChangesAsync();
                //_context.Database.CommitTransaction();
                TempData["Message"] = "Servicio guardado correctamente!.";
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", (e.InnerException != null ? e.InnerException.Message : e.Message));
                ViewBag.Escuelas = _context.Escuela.ToList();
                ViewBag.TipoPersonas = _context.TipoPersona.ToList();
                return View(servicio);
            }

        }

        // GET: Servicios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            if (!_context.Modulo.Any(x => x.nombreModulo == "Servicios" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }

            if (id == null)
            {
                return NotFound();
            }

            ViewBag.Escuelas = _context.Escuela.ToList();
            ViewBag.TipoPersonas = _context.TipoPersona.ToList();

            var servicio = await _context.Servicios.FindAsync(id);
            if (servicio == null)
            {
                return NotFound();
            }
            return View(servicio);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idServicio,nombreServicio,idEscuela,prioridad,idTipoPersona")] Servicio servicio, List<string> usr)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Servicios" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            if (id != servicio.idServicio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(servicio);
                    await _context.SaveChangesAsync();

                    var lis = _context.RequeridosServicio.Where(x => x.idServicio == servicio.idServicio).ToList();
                    foreach (RequeridosServicio rs in lis)
                    {
                        _context.RequeridosServicio.Remove(rs);
                        await _context.SaveChangesAsync();
                    }

                    await _context.SaveChangesAsync();

                    if (usr.Count > 0)
                    {
                        foreach (string reque in usr)
                        {
                            var re = _context.Requeridos.SingleOrDefault(x => x.nombreRequerido == reque).idRequerido;

                            _context.RequeridosServicio.Add(new RequeridosServicio()
                            {
                                idServicio = servicio.idServicio,
                                idRequerido = re
                            });
                        }

                        await _context.SaveChangesAsync();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServicioExists(servicio.idServicio))
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
            return View(servicio);
        }

        // GET: Servicios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Servicios" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            if (id == null)
            {
                return NotFound();
            }

            var servicio = await _context.Servicios
                .FirstOrDefaultAsync(m => m.idServicio == id);

            var modelo = new ServiciosViewModel();

            modelo.idServicio = servicio.idServicio;
            modelo.nombreServicio = servicio.nombreServicio;
            modelo.idEscuela = servicio.idEscuela;
            modelo.prioridad = servicio.prioridad;
            modelo.stringTipoPersona = _context.TipoPersona.SingleOrDefault(y => y.idTipoPersona == servicio.idTipoPersona).nombreTipoPersona;
            modelo.idTipoPersona = servicio.idTipoPersona;
            modelo.nombreEscuela = _context.Escuela.SingleOrDefault(z => z.idEscuela == servicio.idEscuela).nombreEscuela;
            if (servicio == null)
            {
                return NotFound();
            }

            return View(modelo);
        }

        // POST: Servicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!_context.Modulo.Any(x => x.nombreModulo == "Servicios" && x.idRol == Convert.ToInt32(User.FindFirstValue("idRol"))))
            {
                return Redirect("../");
            }
            var servicio = await _context.Servicios.FindAsync(id);
            _context.Servicios.Remove(servicio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServicioExists(int id)
        {
            return _context.Servicios.Any(e => e.idServicio == id);
        }
    }
}
