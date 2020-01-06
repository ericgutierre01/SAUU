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
    public class UsuarioHelper
    {
        private readonly SAUUContext _db;
        public UsuarioHelper(SAUUContext context)
        {
            _db = context;
        }

        public async Task Create(Usuario args)
        {
            args.passUsuario = Encryption.Encrypt(args.passUsuario);
            _db.Usuarios.Update(args);
            await _db.SaveChangesAsync();
        }

        public async Task<UsuarioViewModel> LogIn(LoginViewModel args)
        {

            var query = await _db.Usuarios.SingleOrDefaultAsync(x => x.nombreUsuario == args.UsuSesion && x.passUsuario == Encryption.Encrypt(args.UsuClave));

            if (query == null)
                return null;

            return new UsuarioViewModel()
            {
                idUsuario = query.idUsuario,
                nombreUsuario = query.nombreUsuario,
                idPersona = query.idPersona,
                idRol = query.idRol
            };
        }

        public IEnumerable<Modulo> GetModuloByRol(int id)
        {
            return _db.Modulo.Where(x => x.idRol == id).ToList();
        }

        public async Task<Usuario> GetByPrimary(int usuId)
        {
            var usuario = await _db.Usuarios.SingleOrDefaultAsync(x => x.idUsuario == usuId);
            return usuario;
        }

        public async Task<Persona> GetPersonaByPrimary(int perId)
        {
            var persona = await _db.Persona.SingleOrDefaultAsync(x => x.idPersona == perId);
            return persona;
        }

        public async Task<Estudiante> GetEstudianteByPrimary(int perId)
        {
            var estudiante = await _db.Estudiantes.SingleOrDefaultAsync(x => x.idPersona == perId);
            return estudiante;
        }

        public IEnumerable<Estudiante> GetEstudiantes()
        {
            return _db.Estudiantes.Select(x => new Estudiante()
            {
                idEstudiante= x.idEstudiante,
                Carrera = x.Carrera,
                idPersona = x.idPersona,
                matriculaEstudiante =x.matriculaEstudiante,
                idEscuela = x.idEscuela
            });
        }

        public IEnumerable<PersonaViewModel> GetPersonas()
        {
            return _db.Persona.Select(x => new PersonaViewModel()
            {
                idTipoPersona = x.idTipoPersona,
                idPersona = x.idPersona,
                nombrePersona = x.nombrePersona,
                apellidoPersona = x.apellidoPersona,
                direccionPersona = x.direccionPersona,
                telefono = x.telefono,
                stringTipoPersona = _db.TipoPersona.SingleOrDefault(y=> y.idTipoPersona == x.idTipoPersona).nombreTipoPersona
            });
        }

        public IEnumerable<TipoPersona> GetTipoPersona()
        {
            return _db.TipoPersona.Select(x => new TipoPersona()
            {
               idTipoPersona = x.idTipoPersona,
               nombreTipoPersona = x.nombreTipoPersona
            });
        }

        public async Task<TipoPersona> GetTipoPersonaByPrimary(int perId)
        {
            return await _db.TipoPersona.SingleOrDefaultAsync(x => x.idTipoPersona == perId);
        }

        public bool VerificarUsuario(int idPersona, string usuario)
        {
            if (_db.Usuarios.Any(x => x.idPersona == idPersona))
                return true;

            if (_db.Usuarios.Any(x => x.nombreUsuario == usuario))
                return true;

            return false;
        }

        public int VerificarEstudiante(string matricula)
        { int estu = 0;
            try
            {
                estu =  _db.Estudiantes.SingleOrDefaultAsync(x => x.matriculaEstudiante == matricula).Result.idPersona;
            }
            catch (Exception)
            {
                estu = 0;
            }
            
            return estu;
        }

        public int VerificarProfesor(string matricula)
        {
            int estu = 0;
            try
            {
                estu = _db.Profesores.SingleOrDefaultAsync(x => x.identificadorProfesor == matricula).Result.idPersona;
            }
            catch (Exception)
            {
                estu = 0;
            }

            return estu;
        }

        public async Task CreatePersona(Persona args)
        {
            _db.Persona.Update(args);
            await _db.SaveChangesAsync();
        }
    }
}
