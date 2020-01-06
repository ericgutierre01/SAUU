using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Models
{
    public class TicketViewModel
    {
        public int idTicket { get; set; }
        [Display(Name = "Asunto", Prompt = "Asunto")]
        public string asunto { get; set; }
        [Display(Name = "Mensaje", Prompt = "Mensaje")]
        public string comentario { get; set; }
        public int idUsuario { get; set; }
        [Display(Name = "Servicio", Prompt = "Servicio")]
        public int idServicio { get; set; }
        public string nombreServicio { get; set; }
        public DateTime fechaCreacion { get; set; }
        public int idEstado { get; set; }

        [Display(Name = "Estado", Prompt = "Estado")]
        public string Estado { get; set; }
        [Display(Name = "Color", Prompt = "Color")]
        public string Color { get; set; }



    }
}
