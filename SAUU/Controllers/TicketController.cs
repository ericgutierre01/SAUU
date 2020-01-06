using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using sauu.Helpers;
using SAUU.Data;
using SAUU.Data.Entities;
using SAUU.Helpers;
using SAUU.Models;

namespace SAUU.Controllers
{
    [Authorize]
    public class TicketController : Controller
    {

        private readonly TicketHelper oTicket;
        private readonly ServicioHelper oServicio;
        private readonly SAUUContext _db;
        private string url;

        public TicketController(SAUUContext context)
        {
            oTicket = new TicketHelper(context);
            oServicio = new ServicioHelper(context);
            _db = context;

        }

        private void CargarServicios()
        {
            var servicios = oServicio.GetByUser(Convert.ToInt32(User.FindFirstValue("idTipoPersona"))).Result;
            ViewBag.Servicios = servicios;
        }

        private void CargarEstados()
        {
            var estados = oTicket.GetEstados();
            ViewBag.Estados = estados;
        }

        private void CargarRequeridos(int id)
        {
            var RS = oServicio.GetRequeridos(id);
            ViewBag.RS = RS;
        }

       // [Authorize]
        public async Task<IActionResult> Index()
        {
            CargarEstados();
            if (User.FindFirstValue("idRol") == "1")
            {
                var ress = oTicket.GetByUser(Convert.ToInt32(User.FindFirstValue("idUsuario")));
                return View(ress);
            }
            else
            {
                var ress =  oTicket.Get();
                return View(ress);
                
            }

        }

        [HttpGet]
        [Route("Ticket/Nuevo")]
        public async Task<IActionResult> Create(int id = 0)
        {
            if (User.FindFirstValue("idRol") != "1")
            {
                TempData["Message"] = "Los Admin no pueden crear tickets!.";
                return RedirectToAction("Index");
            }
            var model = new Ticket();
            /* if (id > 0)
                 model = await oGasto.GetByPrimary(id);*/

            //CargarSelects();
            CargarServicios();
           // CargarRequeridos(2);
            return View(model);
        }

        [HttpPost]
        [Route("Ticket/Nuevo")]
        public async Task<IActionResult> Create(Ticket args, [FromForm(Name = "archivos")] List<IFormFile> archivos)
        {
            try
            {

                if (archivos.Count > 0)
                {

                    foreach (IFormFile fi in archivos)
                    {
                        var error = Utils.ValidarFoto(fi);
                        if (error.Length > 0) throw new Exception(error);
                    }
                }

                if (!ModelState.IsValid)
                    throw new Exception("Debes llenar todos los campo!.");

                string path = "", currentPath = "", fileName = "";

                args.idEstado = 2;
                args.fechaCreacion = DateTime.Now;
                args.idUsuario = Convert.ToInt32(User.FindFirstValue("idUsuario"));

                _db.Tickets.Add(args);
                await _db.SaveChangesAsync();

                if (archivos.Count > 0)
                {

                    foreach (IFormFile fi in archivos)
                    {
                        var error = Utils.ValidarFoto(fi);
                        if (error.Length > 0) throw new Exception(error);


                        fileName = Guid.NewGuid().ToString() + Path.GetExtension(fi.FileName);
                        path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/archivos", fileName);
                       // if (!string.IsNullOrEmpty(model.EstFoto))
                            currentPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/archivos", args.idTicket.ToString());


                        if (path.Length > 0)
                            using (var stream = new FileStream(path, FileMode.Create))
                                await fi.CopyToAsync(stream);

                        _db.TicketAdjuntos.Add(new TicketAdjunto()
                        {
                            idTicket= args.idTicket,
                            archivo= fileName,
                            idRequerido = args.idServicio
                        });
                    }

                }
                await _db.SaveChangesAsync();

                
                //_db.Database.CommitTransaction();
                try
                {
                    var idEscu = 1;/*_db.Servicios.SingleOrDefault(x => x.idServicio == args.idUsuario).idEscuela;*/
                    var correo =  _db.Escuela.SingleOrDefault(x => x.idEscuela == idEscu).correo;
                    string correoP = _db.Persona.SingleOrDefault(x => x.idPersona == Convert.ToInt32(User.FindFirstValue("idPersona"))).correo;
                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress("escuelainformatica@sauu.dx.am");
                        //destination adress
                        mail.To.Add(correo);
                        mail.To.Add(correoP);
                        mail.Subject = "SAUU Ticket Nuevo";
                        mail.Body = "Se creo un nuevo ticket. Numero del ticket: " + args.idTicket + " Asunto: " + args.asunto + " Creado: " + args.fechaCreacion +
                            " Puedes acceder al ticket desde este enlace: " + Request.Scheme + "://" + Request.Host.ToString() + "/" + "Ticket/Ver/"+ args.idTicket;
                        //set to true, to specify that we are sending html text.
                        mail.IsBodyHtml = true;
                        using (SmtpClient smtp = new SmtpClient("xfer.mboxhosting.com", 587))
                        {
                            //passing the credentials for authentication
                            smtp.Credentials = new NetworkCredential
                            ("escuelainformatica@sauu.dx.am", "sauu2019");
                            //Authentication required
                            smtp.EnableSsl = false;
                            //sending email.
                            smtp.Send(mail);
                        }
                    }
                
                }
                catch(Exception)
                {
                    Console.WriteLine("no se envio");
                }

                TempData["Message"] = "Ticket guardado correctamente!.";
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", (e.InnerException != null ? e.InnerException.Message : e.Message));
                CargarServicios();
                return View(args);
            }
        }

        [HttpGet("Ticket/Ver/{id}")]
        public async Task<IActionResult> Detail(int id = 0)
        {
            if (User.FindFirstValue("idRol") != "1")
            {
                return Redirect("../Responder/"+id);
                //return RedirectToAction("DetailResponder");
            }

            var model = await oTicket.GetByPrimary(id);
            if (model == null)
                throw new Exception("Error, Registro no encontrado!");

            var servicioString = oServicio.GetServicioByPrimary(model.idServicio);
            ViewBag.servicioNombre = servicioString.nombreServicio;

            var EstadoString = _db.Estados.SingleOrDefault(x => x.idEstado == model.idEstado);
            ViewBag.estadoNombre = EstadoString.nombreEstado;
          
            return View(model);
        }

        [HttpGet("Ticket/Responder/{id}")]
        public async Task<IActionResult> DetailResponder(int id = 0)
        {
            if (User.FindFirstValue("idRol") == "1")
            {
                return Redirect("../Ver/" + id);
            }
            var model = await oTicket.GetByPrimary(id);
            if (model == null)
                throw new Exception("Error, Registro no encontrado!");

            CargarEstados();
            var servicioString = oServicio.GetServicioByPrimary(model.idServicio);
            ViewBag.servicioNombre = servicioString.nombreServicio;

            var usuarioString = _db.Usuarios.SingleOrDefault(x => x.idUsuario == model.idUsuario);
            var personaString = _db.Persona.SingleOrDefault(x => x.idPersona == usuarioString.idPersona);

            ViewBag.usuarioNombre = personaString.nombrePersona+" "+ personaString.apellidoPersona;
            ViewBag.personaId = personaString.idPersona;
            var tra = new TrakingTicket()
            {
                idTicket = id,
                cambioRealizado = "Abrio ticket",
                idUser = Convert.ToInt32(User.FindFirstValue("idUsuario")),
                fechaTraking = DateTime.Now
            };
            _db.TrakingTicket.Add(tra);
            await _db.SaveChangesAsync();

            return View(model);
        }

        [HttpPost("Ticket/Responder/{id}")]
        public async Task<IActionResult> DetailResponder(Ticket args, string respuesta)
        {
            try
            {
                _db.Tickets.Update(args);

                if (respuesta != null)
                {
                    _db.TicketRespuesta.Add(new TicketRespuesta()
                    {
                        idTicket = args.idTicket,
                        mensaje = respuesta,
                        idUsuario = Convert.ToInt32(User.FindFirstValue("idUsuario"))
                    });
                }


                var estad = _db.Estados.SingleOrDefault(v => v.idEstado == args.idEstado).nombreEstado;
                var tra = new TrakingTicket()
                {
                    idTicket = args.idTicket,
                    cambioRealizado = "(Respondio: " + respuesta + " -Nuevo Estado: " + estad +")",
                    idUser = Convert.ToInt32(User.FindFirstValue("idUsuario")),
                    fechaTraking = DateTime.Now
                };
                _db.TrakingTicket.Add(tra);

                await _db.SaveChangesAsync();

                TempData["Message"] = "Ticket guardado correctamente!.";
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", (e.InnerException != null ? e.InnerException.Message : e.Message));
                CargarEstados();
                var servicioString = oServicio.GetServicioByPrimary(args.idServicio);
                ViewBag.servicioNombre = servicioString.nombreServicio;

                var usuarioString = _db.Usuarios.SingleOrDefault(x => x.idUsuario == args.idUsuario);
                var personaString = _db.Persona.SingleOrDefault(x => x.idPersona == usuarioString.idPersona);

                ViewBag.usuarioNombre = personaString.nombrePersona + " " + personaString.apellidoPersona;

                return View(args);
            }

        }

        [HttpGet]
        public JsonResult GetJson(int id)
        {
            var RSs = oServicio.GetRequeridos(id);
            CargarRequeridos(id);
            return Json(RSs);
        }

        [HttpGet]
        public JsonResult GetAllRequeJson()
        {
            var All = oServicio.GetAllRequeridos();
            return Json(All);
        }

        [HttpGet]
        public JsonResult GetArchivosJson(int Id)
        {

            var Adjuntos = oTicket.GetAdjuntoByTicket(Id);
            return Json(Adjuntos);
        }

        [HttpGet]
        public JsonResult GetRespuestasJson(int Id)
        {

            var respuestas = oTicket.GetRespuestas(Id);
            return Json(respuestas);
        }

        [HttpGet]
        public JsonResult GetTrakingJson(int Id)
        {
            var traking = oTicket.GetTraking(Id);
            return Json(traking);
        }

    }
}