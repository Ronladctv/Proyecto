using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Proyecto.Models.Entidades
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idUser { get; set; }

        [Required(ErrorMessage = "El campo {nomAutor} es obligatorio")]
        public string nomAutor { get; set; }
        public string apAutor { get; set; }

        public string correo { get; set; }

        public string password { get; set; }
        public DateTime fecha { get; set; }

        public Roles roles { get; set; }
    }
}
