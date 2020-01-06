using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Data.Entities
{
    public class Servicio
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idServicio { get; set; }
        [Display(Name = "Nombre", Prompt = "Nombre")]
        public string nombreServicio { get; set; }
        [Display(Name = "Dueño", Prompt = "Dueño")]
        public int idEscuela { get; set; }
        [Display(Name = "Prioridad", Prompt = "Prioridad")]
        public string prioridad { get; set; }
        [Display(Name = "Dirigido a", Prompt = "Dirigido a")]
        public int idTipoPersona { get; set; }
    }
}
