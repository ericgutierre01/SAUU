using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Data.Entities
{
    public class TrakingTicket
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idTraking { get; set; }
        [Display(Name = "Usuario", Prompt = "Usuario")]
        public int idUser { get; set; }
        [Display(Name = "Cambio", Prompt = "Cambio")]
        public string cambioRealizado { get; set; }
        public int idTicket{ get; set; }
        [Display(Name = "Fecha", Prompt = "Fecha")]
        public DateTime fechaTraking { get; set; }
    }
}
