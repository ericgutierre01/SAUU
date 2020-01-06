using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAUU.Data.Entities
{
    public class Requerido
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idRequerido { get; set; }
        public string nombreRequerido { get; set; }
    }
}
