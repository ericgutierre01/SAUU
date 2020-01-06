using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Data.Entities
{
    public class Modulo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idModulo { get; set; }
        [Display(Name = "Nombre", Prompt = "Nombre")]
        public string nombreModulo { get; set; }
        [Display(Name = "Rol", Prompt = "Rol")]
        public int idRol { get; set; }
    }
}
