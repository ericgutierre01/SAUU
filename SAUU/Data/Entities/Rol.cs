using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Data.Entities
{
    public class Rol
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idRol { get; set; }
        [Display(Name = "Nombre", Prompt = "Nombre")]
        public string nombreRol { get; set; }
    }
}
