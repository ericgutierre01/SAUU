using Microsoft.EntityFrameworkCore;
using SAUU.Data.Entities;
using SAUU.Models;

namespace SAUU.Data
{
    public class SAUUContext : DbContext
    {

        public SAUUContext(DbContextOptions<SAUUContext> options)
            : base(options)
        {
        }


        //          ||| SEGURIDAD |||  ------->
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Requerido> Requeridos { get; set; }
        public DbSet<RequeridosServicio> RequeridosServicio { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Usuario> Usuarios{ get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<TipoPersona> TipoPersona { get; set; }
        public DbSet<Modulo> Modulo { get; set; }
        public DbSet<TicketAdjunto> TicketAdjuntos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<TicketRespuesta> TicketRespuesta { get; set; }
        public DbSet<Escuela> Escuela { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Facultad> Facultad { get; set; }
        public DbSet<TrakingTicket> TrakingTicket { get; set; }
        public DbSet<SAUU.Models.UsuarioCompletoViewModel> UsuarioCompletoViewModel { get; set; }

    }
}
