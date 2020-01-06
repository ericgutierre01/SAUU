using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Data.Entities
{
    public class Usuario
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string passUsuario { get; set; }
        public int idPersona { get; set; }
        public int idRol { get; set; }
    }
}
