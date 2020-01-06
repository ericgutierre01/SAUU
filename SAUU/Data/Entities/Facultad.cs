using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Data.Entities
{
    public class Facultad
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idFacultad { get; set; }
        [Display(Name = "Nombre de la facultad", Prompt = "Nombre de la facultad")]
        public string nombreFacultad { get; set; }
    }
}
