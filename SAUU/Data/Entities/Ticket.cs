using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Data.Entities
{
    public class Ticket
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idTicket { get; set; }
        [Display(Name = "Asunto", Prompt = "Asunto")]
        public string asunto { get; set; }
        [Display(Name = "Mensaje", Prompt = "Mensaje")]
        public string comentario { get; set; }
        public int idUsuario { get; set; }
        [Display(Name = "Servicio", Prompt = "Servicio")]
        public int idServicio { get; set; }
        public DateTime fechaCreacion { get; set; }
        public int idEstado { get; set; }
    }
}
