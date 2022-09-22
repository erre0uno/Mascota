using Microsoft.EntityFrameworkCore;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{

    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        //public DbSet<Persona> Personas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Dueno> Duenos { get; set; }

        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Historia> Historias { get; set; }
        public DbSet<Visita> Visitas { get; set; }

        /* 
            public DbSet<Medico> Medicos { get; set; }
            public DbSet<Enfermero> Enfermeros { get; set; }
            public DbSet<Familiar> Familiares { get; set; }
            public DbSet<Paciente> Pacientes { get; set; }
            public DbSet<Signovital> Signosvitales { get; set; }
            public DbSet<Sugerencia> Sugerencias { get; set; }
        */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//                optionsBuilder
//                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; initial Catalog = MascotaDB");
/*
  "ConnectionStrings": {
    "conexion":"Server=(localdb)\\mssqllocaldb;Database=MascotaDB;Trusted_Connection=True;"}
*/
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dueno>(entity =>
            {
                entity.Property(e => e.DuenoID).HasColumnName("DuenoID");

                entity.Property(e => e.Apellidos).HasMaxLength(50);

                entity.Property(e => e.Correo).HasMaxLength(65);

                entity.Property(e => e.Direccion).HasMaxLength(80);

                entity.Property(e => e.Telefono).HasMaxLength(21);

                entity.Property(e => e.Nombres).HasMaxLength(50);
            });
        }





    }

}