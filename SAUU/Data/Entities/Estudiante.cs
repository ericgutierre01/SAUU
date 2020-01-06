using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Data.Entities
{
    public class Estudiante
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idEstudiante { get; set; }
        public int idPersona { get; set; }
        public string matriculaEstudiante { get; set; }
        public string Carrera { get; set; }
        public int idEscuela { get; set; }
    }
}
