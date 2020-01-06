using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Models
{
    public class RequeridosServicioViewModel
    {
        public int idRS { get; set; }
        public int idServicio { get; set; }
        public string nombre { get; set; }
        public int idRequerido { get; set; }
    }
}
