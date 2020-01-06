using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Models
{
    public class PersonaViewModel
    {
        public int idPersona { get; set; }
        [Display(Name = "Nombre", Prompt = "Nombre")]
        public string nombrePersona { get; set; }
        [Display(Name = "Apellidos", Prompt = "Apellidos")]
        public string apellidoPersona { get; set; }
        [Display(Name = "Tipo", Prompt = "Tipo")]
        public int idTipoPersona { get; set; }
        public string stringTipoPersona { get; set; }
        [Display(Name = "Telefono", Prompt = "Telefono")]
        public string telefono { get; set; }
        [Display(Name = "Correo", Prompt = "Correo")]
        public string correo { get; set; }
        [Display(Name = "Direccion", Prompt = "Direccion")]
        public string direccionPersona { get; set; }
    }
}
