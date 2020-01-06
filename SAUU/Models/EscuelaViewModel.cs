using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Models
{
    public class EscuelaViewModel
    {
        public int idEscuela { get; set; }
        [Display(Name = "Nombre", Prompt = "Nombre")]
        public string nombreEscuela { get; set; }
        [Display(Name = "Facultad", Prompt = "Facultad")]
        public int idFacultad { get; set; }
        public string nombreFacultad { get; set; }
        [Display(Name = "Correo", Prompt = "Correo")]
        public string correo { get; set; }
    }
}
