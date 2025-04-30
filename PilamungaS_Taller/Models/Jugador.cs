using System.ComponentModel.DataAnnotations;

namespace PilamungaS_Taller.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumeroCamiseta { get; set; }
        public int Goles {  get; set; }
        public int AsistenciasTotales { get; set; }
        public float Sueldo { get; set; }
    }
}
