namespace PilamungaS_Taller.Models
{
    public class Reporte
    {
        public List<Jugador> Goleadores {  get; set; }
        public List<Jugador> Asistentes { get; set; }
        public List<Jugador> EquipoMayorPresupuesto { get; set; }

    }
    public class EquipoMayorPresupuesto
    {
        public String NombreEquipo { get; set; }
        public float Presupuesto { get; set; }
    }
}
