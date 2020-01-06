using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Data.Entities
{
    public class Persona
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPersona { get; set; }
        [Display(Name = "Nombre", Prompt = "Nombre")]
        public string nombrePersona { get; set; }
        [Display(Name = "Apellidos", Prompt = "Apellidos")]
        public string apellidoPersona { get; set; }
        [Display(Name = "Tipo", Prompt = "Tipo")]
        public int idTipoPersona { get; set; }
        //public string stringTipoPersona { get; set; }
        [Display(Name = "Telefono", Prompt = "Telefono")]
        public string telefono { get; set; }
        [Display(Name = "Correo", Prompt = "Correo")]
        public string correo { get; set; }
        [Display(Name = "Direccion", Prompt = "Direccion")]
        public string direccionPersona { get; set; }
        [Display(Name = "Cedula", Prompt = "Cedula")]
        public string cedulaPersona { get; set; }
        [Display(Name = "Fecha", Prompt = "Fecha")]
        public DateTime fechaNacimiento { get; set; }
    }
}
