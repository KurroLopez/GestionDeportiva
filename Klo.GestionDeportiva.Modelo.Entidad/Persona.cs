using System.ComponentModel.DataAnnotations;

namespace Klo.GestionDeportiva.Modelo.Entidad
{
    public class Persona
    {
        /// <summary>
        /// Id persona
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Nombre de la persona
        /// </summary>
        [StringLength(50)]
        public required string Nombre { get; set; }

        /// <summary>
        /// Apellidos de la persona
        /// </summary>
        [StringLength(50)]
        public required string Apellidos { get; set; }

        /// <summary>
        /// Dni/nie de la persona
        /// </summary>
        public string? Dni { get; set; }

        /// <summary>
        /// Fecha de nacimiento de la persona
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaNacimiento { get; set; }

    }
}
