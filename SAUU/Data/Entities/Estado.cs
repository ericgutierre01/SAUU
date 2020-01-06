using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Data.Entities
{
    public class Estado
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idEstado{ get; set; }
        [Display(Name = "Nombre", Prompt = "Nombre")]
        public string nombreEstado { get; set; }
        [Display(Name = "Color", Prompt = "Color")]
        public string colorEstado { get; set; }
    }
}
