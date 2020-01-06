using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Models
{
    public class ServiciosViewModel
    {
        public int idServicio { get; set; }
        [Display(Name = "Nombre", Prompt = "Nombre")]
        public string nombreServicio { get; set; }
        [Display(Name = "Escuela", Prompt = "Escuela")]
        public int idEscuela { get; set; }
        public string nombreEscuela { get; set; }
        [Display(Name = "Prioridad", Prompt = "Prioridad")]
        public string prioridad { get; set; }
        [Display(Name = "Dirigido a", Prompt = "Dirigido a")]
        public int idTipoPersona { get; set; }
        public string stringTipoPersona { get; set; }

    }
}
