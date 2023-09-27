using ConsultaMedica.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsultaMedica.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consulta>().ToTable("Consultas");
            modelBuilder.Entity<Medico>().ToTable("Medicos");
        }

    }
}
