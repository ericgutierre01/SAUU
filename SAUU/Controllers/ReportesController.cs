using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SAUU.Data;
using SAUU.Data.Entities;
using SAUU.Models;

namespace SAUU.Controllers
{
    public class ReportesController : Controller
    {
        private readonly SAUUContext _db;

        public ReportesController(SAUUContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetChartJson()
        {

            var activos = _db.Tickets.Where(x => x.idEstado == 1).Count();
            var pendiente = _db.Tickets.Where(x => x.idEstado == 2).Count();
            var declinado = _db.Tickets.Where(x => x.idEstado == 3).Count();
            var respondido = _db.Tickets.Where(x => x.idEstado == 7).Count();
            List<ChartTicket> chart = new List<ChartTicket>();
            chart.Add(new ChartTicket { estado = "Activos", Total = activos });
            chart.Add(new ChartTicket { estado = "Pendientes", Total = pendiente });
            chart.Add(new ChartTicket { estado = "Declinados", Total = declinado });
            chart.Add(new ChartTicket { estado = "Respondidos", Total = respondido });
            
            return Json(chart);
        }

        [HttpGet]
        public JsonResult GetChartTrakingJson()
        {
            var listUser = _db.Usuarios.Where(x => x.idRol != 1).ToList();
            var list = new List<ChartTicketsByUsers>();
            foreach (Usuario user in listUser)
            {
                var r = _db.TrakingTicket.Where(x => x.idUser == user.idUsuario).Where(c => c.cambioRealizado.Contains("Respondido")).Count();
                var a = _db.TrakingTicket.Where(x => x.idUser == user.idUsuario).Where(c => c.cambioRealizado.Contains("Activo")).Count();
                var ca = _db.TrakingTicket.Where(x => x.idUser == user.idUsuario).Where(c => c.cambioRealizado.Contains("Declinado")).Count();
                var p = _db.TrakingTicket.Where(x => x.idUser == user.idUsuario).Where(c => c.cambioRealizado.Contains("Abrio")).Count();
                var ns = _db.Usuarios.SingleOrDefault(z => z.idUsuario == user.idUsuario).nombreUsuario;

                list.Add(new ChartTicketsByUsers { UserNombre = ns, Activos = a, Pendiente =p, Cancelados = ca, Respondidos = r});

            }
               
            return Json(list);
        }
    }
}