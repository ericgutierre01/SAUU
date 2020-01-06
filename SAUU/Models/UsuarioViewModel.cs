using System;
using System.ComponentModel.DataAnnotations;

namespace SAUU.Models
{
    public class UsuarioViewModel
    {
        public int idUsuario { get; set; }
        [Required, Display(Name = "Usuario", Prompt = "Usuario")]
        public string nombreUsuario { get; set; }
        [Display(Name = "Contraseñas", Prompt = "Contraseñas")]
        public string passUsuario { get; set; }
        [Display(Name = "Confirmar Contraseñas", Prompt = "Confirmar Contraseñas")]
        public string passUsuarioConfirm { get; set; }
        public int idPersona { get; set; }
        public int idRol { get; set; }
        public string Token { get; set; }
        public DateTime TokenExpiresUtc { get; set; }
    }
}
