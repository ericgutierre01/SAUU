using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Data.Entities
{
    public class Profesor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idProfesor{ get; set; }
        public string identificadorProfesor { get; set; }
        public int idPersona { get; set; }
    }
}
