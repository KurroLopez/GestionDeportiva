using System.ComponentModel.DataAnnotations;

namespace Klo.GestionDeportiva.Modelo.Entidad
{
    public class Jugador
    {
        [Key]
        public long Id { get; set; }
        public long PersonaId { get; set; }
        public required Persona Persona { get; set; }
        public long EquipoId { get; set; }
        public required Equipo Equipo { get; set; }
        public bool Autorizado { get; set; }

    }
}
