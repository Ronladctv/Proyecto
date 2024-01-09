using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models.Entidades
{
    public class Estado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idEstado { get; set; }

        public string estado { get; set; }

    }
}
