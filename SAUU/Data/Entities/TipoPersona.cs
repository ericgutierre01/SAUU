using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Data.Entities
{
    public class TipoPersona
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idTipoPersona { get; set; }
        [Display(Name = "Nombre del Tipo", Prompt = "Nombre del Tipo")]
        public string nombreTipoPersona { get; set; }
    }
}
