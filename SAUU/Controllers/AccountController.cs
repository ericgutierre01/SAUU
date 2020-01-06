using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SAUU.Data;
using SAUU.Data.Entities;
using SAUU.Helpers;
using SAUU.Models;

namespace SAUU.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UsuarioHelper oUsuario;
        private readonly SAUUContext _db;

        public AccountController(SAUUContext context)
        {
            oUsuario = new UsuarioHelper(context);
            _db = context;
        }

        [HttpGet("/Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl)
        {

            //ViewData["ReturnUrl"] = returnUrl;

            await HttpContext.SignOutAsync();

            return View(new LoginViewModel());
        }

        [HttpPost("/Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel args, string returnUrl)
        {
            //ViewData["ReturnUrl"] = returnUrl;

            if (!ModelState.IsValid)
                return View(args);

            try
            {
                var usuario = await oUsuario.LogIn(args);
                var persona = await oUsuario.GetPersonaByPrimary(usuario.idPersona);
                if (usuario != null)
                {
                    //Guardar Session en Cookie
                    var lista = new List<Estado>();
                    var claims = new List<Claim>() {
                        new Claim("idUsuario", usuario.idUsuario.ToString()),
                        new Claim("idRol", usuario.idRol.ToString()),
                        new Claim("idPersona", persona.idPersona.ToString()),
                         new Claim("idTipoPersona", persona.idTipoPersona.ToString()),
                        new Claim(ClaimTypes.Name, $"{persona.nombrePersona} {persona.apellidoPersona}")
                        
                    };

                    var userIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "Ticket");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "Usuario o clave invalido!");
                
            }
            return View(args);
        }

        [HttpPost("/Logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

           //return RedirectToAction("Login", "Account");
            return RedirectToAction("Index", "Ticket");
        }

        [HttpGet("/Registro")]
        [AllowAnonymous]
        public async Task<IActionResult> Registro(string returnUrl)
        {
            //ViewData["ReturnUrl"] = returnUrl;
            var model = new Usuario(); ;
            CargarPersona();
            return View(new Usuario());
        }

        [HttpPost("/Registro")]
        [AllowAnonymous]
        public async Task<IActionResult> Registro(Usuario args, string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (!ModelState.IsValid)
                return View(args);
            try
            {
                if (oUsuario.VerificarUsuario(args.idPersona, args.nombreUsuario))
                {
                    ModelState.AddModelError("", "Datos ya existen!");
                    CargarPersona();
                    return View(args);
                }

                args.idRol = 1;
                await oUsuario.Create(args);
                return RedirectToAction("Login");
            }
            catch (Exception)
            {
               ModelState.AddModelError("", "No se pudo Crear el usuario!");
                CargarPersona();
                return View(args);
            }
        }

        [HttpGet]
        [Route("/Perfil")]
        public async Task<IActionResult> Perfil()
        {
            var model = new UsuarioCompletoViewModel();
            Usuario user = await oUsuario.GetByPrimary(Convert.ToInt32(User.FindFirstValue("idUsuario")));
            Persona persona = await oUsuario.GetPersonaByPrimary(Convert.ToInt32(User.FindFirstValue("idPersona")));


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

        private void CargarPersona()
        {
            var Tpersona = oUsuario.GetTipoPersona();
            ViewBag.TipoPersona = Tpersona;
        }

        [HttpGet]
        public JsonResult GetModulosJson()
        {

            var Modulos = oUsuario.GetModuloByRol(Convert.ToInt32(User.FindFirstValue("idRol")));
            return Json(Modulos);
        }

    }
}