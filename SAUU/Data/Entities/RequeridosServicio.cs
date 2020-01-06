using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SAUU.Data.Entities
{
    public class RequeridosServicio
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idRS { get; set; }
        public int idServicio { get; set; }
        public int idRequerido { get; set; }
    }
}
