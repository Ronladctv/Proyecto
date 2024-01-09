using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models.Entidades
{
    public class Citas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCitas { get; set; }

        public DateTime fecha { get; set; }
        public TimeOnly hora { get; set; }
        public string observaciones { get; set; }

        public string estado { get; set; }
        public DateTime fecha_registro { get; set; }
        public Paciente paciente { get; set; }
        public Doctor doctor { get; set; }
        public Especialidad especialidad { get; set; }
        
    }
}
