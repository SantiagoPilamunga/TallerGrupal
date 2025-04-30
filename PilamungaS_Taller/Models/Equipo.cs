using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PilamungaS_Taller.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Nombre del equipo")]
        public string Nombre { get; set; }
        //[Range(0,100)]
        //public int PartidosJugados {  get; set; }
        [Range(0, 100)]
        public int PartidosGanados {  get; set; }
        [Range(0, 100)]
        public int PartidosEmpatados { get; set; }
        [Range(0, 100)]
        public int PartidosPerdidos { get; set; }
        [Range(0, 100)]
        public int Puntos => (PartidosGanados * 3) + (PartidosEmpatados * 1); //Calculamos directamente los puntos que obtienen cada equipo
        public int PartidosJugados => PartidosGanados+PartidosEmpatados+PartidosPerdidos; //calculamos directamente los partidos jugados
        public string Descripcion { get; set; }
        public string Logo { get; set; }


        public ICollection<Jugador> Jugadores { get; set; }

    }
}
