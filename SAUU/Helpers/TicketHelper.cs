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
    public class TicketHelper
    {
        private readonly SAUUContext _db;
        public TicketHelper(SAUUContext context) => _db = context;

        public IEnumerable<TicketViewModel> Get()
        {
            return  _db.Tickets.Select(x => new TicketViewModel()
            {
                idTicket= x.idTicket,
                asunto = x.asunto,
                comentario = x.comentario,
                fechaCreacion = x.fechaCreacion,
                idServicio = x.idServicio,
                idEstado = x.idEstado,
                idUsuario = x.idUsuario,
                Color = _db.Estados.SingleOrDefault(y => y.idEstado == x.idEstado).colorEstado,
                Estado = _db.Estados.SingleOrDefault(y => y.idEstado == x.idEstado).nombreEstado,
                nombreServicio = _db.Servicios.SingleOrDefault(y => y.idServicio == x.idServicio).nombreServicio,
            });
        }

        public IEnumerable<TicketViewModel> GetByUser(int id)
        {
            return _db.Tickets.Where(x => x.idUsuario == id).Select(x => new TicketViewModel()
            {
                idTicket = x.idTicket,
                asunto = x.asunto,
                comentario = x.comentario,
                fechaCreacion = x.fechaCreacion,
                idServicio = x.idServicio,
                idEstado = x.idEstado,
                idUsuario = x.idUsuario,
                Color = _db.Estados.SingleOrDefault(y => y.idEstado == x.idEstado).colorEstado,
                Estado = _db.Estados.SingleOrDefault(y => y.idEstado == x.idEstado).nombreEstado,
                nombreServicio = _db.Servicios.SingleOrDefault(y => y.idServicio == x.idServicio).nombreServicio,
            });
        }

        public async Task Create(Ticket args)
        {
            _db.Tickets.Update(args);
            await _db.SaveChangesAsync();
        }

        public async Task<Ticket> GetByPrimary(int id)
        {
            var query = await _db.Tickets
               .SingleOrDefaultAsync(x => x.idTicket == id);

            return query;
        }


        public IEnumerable<TicketAdjunto> GetAdjuntoByTicket(int id)
        {
            return  _db.TicketAdjuntos.Where(x => x.idTicket == id).ToList();
        }

        public  IEnumerable<Estado> GetEstados()
        {
            return _db.Estados.Select(x => new Estado()
            {
                idEstado = x.idEstado,
                nombreEstado = x.nombreEstado,
                colorEstado = x.colorEstado
            });
        }

        public IEnumerable<TicketRespuesta> GetRespuestas(int id)
        {
            return _db.TicketRespuesta.Where(x => x.idTicket == id).ToList();
        }

        public IEnumerable<TrakingTicket> GetTraking(int id)
        {
            return _db.TrakingTicket.Where(x => x.idTicket == id).ToList();
        }

    }
}
