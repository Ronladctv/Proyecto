using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models.Entidades
{
    public class Horario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idHorario { get; set; }

        public string dias { get; set; }
        public DateTime fecha { get; set; }


        public Doctor doctor { get; set; }


    }
}
