using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SAUU.Data;
using SAUU.Data.Entities;
using SAUU.Helpers;
using SAUU.Models;

namespace SAUU.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioHelper oPersona;
        private readonly SAUUContext _db;

        public UsuarioController(SAUUContext context)
        {
            _db = context;
            oPersona = new UsuarioHelper(context);
        }

        [HttpGet]
        [Route("Usuario/Editar")]
        public async Task<IActionResult> Create()
        {
            var model = new UsuarioCompletoViewModel();
            Usuario user = await oPersona.GetByPrimary(Convert.ToInt32(User.FindFirstValue("idUsuario")));
            Persona persona = await oPersona.GetPersonaByPrimary(Convert.ToInt32(User.FindFirstValue("idPersona")));


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
                stringTipoPersona = _db.TipoPersona.SingleOrDefault(y => y.idTipoPersona == persona.idTipoPersona).nombreTipoPersona
            };

            if (_db.TipoPersona.SingleOrDefault(s => s.idTipoPersona == persona.idTipoPersona).nombreTipoPersona == "Estudiante")
            {
                modelC.estudiante = _db.Estudiantes.SingleOrDefault(x => x.idPersona == persona.idPersona);
            }
            else
            {
                modelC.profesor = _db.Profesores.SingleOrDefault(x => x.idPersona == persona.idPersona);
            }

            model.idUsuario = user.idUsuario;
            model.idPersona = user.idPersona;
            model.idRol = user.idRol;
            model.nombreUsuario = user.nombreUsuario;
            model.persona = modelC;

            return View(model);
        }


        [HttpGet]
        private void CargarPersona()
        {
            var Tpersona = oPersona.GetTipoPersona();
            ViewBag.TipoPersona = Tpersona; 
        }

        [HttpGet]
        public JsonResult GetJson(string valor)
        {
            string[] tipo = valor.Split('?');
            int verificado = 0;
            if (tipo[1]== "1")
            {
                verificado = oPersona.VerificarEstudiante(tipo[0]);
            }
            if (tipo[1] == "2")
            {
                verificado = oPersona.VerificarProfesor(tipo[0]);
            }

            return Json(verificado);
        }

    }
}