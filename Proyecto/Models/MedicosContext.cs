using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Reflection.Emit;
using Proyecto.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Proyecto.Models
{
    public class MedicosContext : DbContext
    {
        public MedicosContext()
        {

        }

        public MedicosContext(DbContextOptions<MedicosContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Citas> Citas { get; set; }
        public DbSet<Doctor> Doctores {  get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        
        public DbSet<Horario> horarios { get; set; }
        public DbSet<Paciente> pacientes { get; set; }
        public DbSet<Roles> Roles { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)  //Este metodo q va ayudar a conectar con la BDD
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
