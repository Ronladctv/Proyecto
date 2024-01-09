using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models.Entidades
{
    public class Paciente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPaciente { get; set; }

        public int cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public int telefono { get; set; }
        public DateTime fecha { get; set; }
        public string estado { get; set; }

    }
}
