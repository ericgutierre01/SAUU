using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Models
{
    public class ChartTicketsByUsers
    {
        public string UserNombre { get; set; }
        public int Activos { get; set; }
        public int Respondidos { get; set; }
        public int Cancelados { get; set; }
        public int Pendiente { get; set; }
        
    }
}
