using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Models
{
    public class ModuloViewModel
    {
        public int idModulo { get; set; }
        [Display(Name = "Nombre", Prompt = "Nombre")]
        public string nombreModulo { get; set; }
        [Display(Name = "Rol", Prompt = "Rol")]
        public string rol { get; set; }
    }
}
