using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Klo.GestionDeportiva.Modelo.Entidad
{
    public class Equipo
    {
        [Key]
        public long Id { get; set; }

        [StringLength(50)]
        public required string Nombre { get; set; }

        public long CategoriaId { get; set; }

        public required Categoria Categoria  { get; set; }
    }

    public class Categoria
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CategoriaId { get; set; }
        
        [StringLength(50)]
        public required string Nombre { get; set; }
    }
}
