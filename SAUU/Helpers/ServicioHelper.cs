using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SAUU.Data;
using SAUU.Data.Entities;
using SAUU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Helpers
{
    public class ServicioHelper
    {
        private readonly SAUUContext _db;
        public ServicioHelper(SAUUContext context) => _db = context;

        public IEnumerable<Servicio> Get()
        {
            return _db.Servicios.Select(x => new Servicio()
            {
                idServicio = x.idServicio,
                nombreServicio = x.nombreServicio,
                idEscuela = x.idEscuela,
                prioridad = x.prioridad
            });
        }

        public async Task <IEnumerable<Servicio>> GetByUser(int id)
        {
            return await _db.Servicios.Where(x => x.idTipoPersona == id).ToListAsync();
        }

        public  Servicio GetServicioByPrimary(int id)
        {
            var query = _db.Servicios
               .SingleOrDefault(x => x.idServicio == id);

            return query;
        }

        public IEnumerable<SelectListItem> GetForSelect()
        {
            return _db.Servicios
                .Select(x => new SelectListItem()
                {
                    Value = x.idServicio.ToString(),
                    Text = x.nombreServicio,
                    Selected = false
                });
        }

        public IEnumerable<RequeridosServicioViewModel> GetRequeridos(int id)
        {
            return _db.RequeridosServicio.Where(i=> i.idServicio == id).Select(x => new RequeridosServicioViewModel()
            {
                idServicio = x.idServicio,
                idRS = x.idRS,
                idRequerido = x.idRequerido,
                nombre = _db.Requeridos.SingleOrDefault(y => y.idRequerido == x.idRequerido).nombreRequerido
            });
        }

        public IEnumerable<Requerido> GetAllRequeridos()
        {
            return _db.Requeridos.Select(x => new Requerido()
            {
                idRequerido =x.idRequerido,
                nombreRequerido = x.nombreRequerido
            });
        }

    }
}
