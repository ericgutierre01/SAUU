using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Data.Entities
{
    public class TicketAdjunto
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idAdjunto { get; set; }
        public string archivo { get; set; }
        public int idTicket { get; set; }
        public int idRequerido { get; set; }
    }
}
