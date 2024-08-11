using Klo.GestionDeportiva.Modelo.Entidad;

namespace Klo.GestionDeportiva.Modelo.AccesoDatos
{
    public static class DbInitializer
    {
        public static void Initialize(GestionDeportivaDbContext context) 
        {
            context.Database.EnsureCreated();
            if (context.Categorias.Any())
            {
                return;   // Categorias ya incializada
            }
            var categorias = new Categoria[]
            {
                new Categoria { CategoriaId = 1, Nombre = "Escuela" },
                new Categoria { CategoriaId = 2, Nombre = "Baby" },
                new Categoria { CategoriaId = 3, Nombre = "PreMini" },
                new Categoria { CategoriaId = 4, Nombre = "Mini" },
                new Categoria { CategoriaId = 5, Nombre = "PreInfantil" },
                new Categoria { CategoriaId = 6, Nombre = "Infantil" },
                new Categoria { CategoriaId = 7, Nombre = "Cadete" },
                new Categoria { CategoriaId = 8, Nombre = "Junior" },
                new Categoria { CategoriaId = 9, Nombre = "Senior" },
            };

            foreach (Categoria s in categorias)
            {
                context.Categorias.Add(s);
            }
            context.SaveChanges();
        }
    }
}
