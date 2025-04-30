using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PilamungaS_Taller.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        [Range(0, 99)]
        public int NumeroCamiseta { get; set; }
        public int Goles { get; set; }
        public int AsistenciasTotales { get; set; }
        public float Sueldo { get; set; }
        [ForeignKey("EquipoId")]
        public int EquipoId { get; set; }
        public Equipo? Equipo { get; set; }
    }
}
