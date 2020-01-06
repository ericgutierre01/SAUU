using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Data.Entities
{
    public class TicketRespuesta
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idRespuesta { get; set; }
        public string mensaje { get; set; }
        public int idUsuario { get; set; }
        public int idTicket { get; set; }
    }
}
