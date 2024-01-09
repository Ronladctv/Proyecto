using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models.Entidades
{
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idDoctor { get; set; }
        public int cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public DateTime fecha { get; set; }
        public string correo { get; set; }
        public DateTime fecha_registro { get; set; }

        public Especialidad especialidad { get; set; }
    }
}
