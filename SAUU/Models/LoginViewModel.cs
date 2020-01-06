using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Debe indicar su nombre de Usuario!")]
        public string UsuSesion { get; set; }
        [Required(ErrorMessage = "Debe indicar la clave de usuario!")]
        public string UsuClave { get; set; }
    }
}
