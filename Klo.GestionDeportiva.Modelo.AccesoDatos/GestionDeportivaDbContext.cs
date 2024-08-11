using Klo.GestionDeportiva.Modelo.Entidad;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Klo.GestionDeportiva.Modelo.AccesoDatos
{
    public class GestionDeportivaDbContext : IdentityDbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }


        public GestionDeportivaDbContext(DbContextOptions<GestionDeportivaDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Persona>()
                .ToTable("Persona")
                .HasKey(e => e.Id);
            modelBuilder.Entity<Equipo>()
                .ToTable("Equipo")
                .HasOne(e => e.Categoria);
            modelBuilder.Entity<Categoria>()
                .ToTable("Categoria")
                .HasKey(e => e.CategoriaId);
            modelBuilder.Entity<Jugador>()
                .ToTable("Jugador")
                .HasOne(e => e.Equipo);
        }
    }
}
