using Microsoft.EntityFrameworkCore;
using PilamungaS_Taller.Data;
using PilamungaS_Taller.Models;

namespace PilamungaS_Taller.Repositorios
{

    public class ReporteRepository
    {
        private readonly PilamungaS_TallerContext _context;
        public ReporteRepository(PilamungaS_TallerContext context)
        {
            _context = context;
        }
        public async Task<Reporte> GenerarReporteAsync()
        {
            var jugadores = await _context.Jugador.Include(j => j.Equipo).ToListAsync();

            var goleadores = jugadores.OrderByDescending(j => j.Goles).Take(5).ToList();
            var asistentes = jugadores.OrderByDescending(j => j.AsistenciasTotales).Take(5).ToList();

            var equipoConMayorPresupuesto = jugadores
                .GroupBy(j => j.Equipo.Nombre)
                .Select(g => new EquipoMayorPresupuesto
                {
                    NombreEquipo = g.Key,
                    Presupuesto = g.Sum(j => j.Sueldo)
                })
                .OrderByDescending(e => e.Presupuesto)
                .Take(1)
                .ToList();

            return new Reporte
            {
                Goleadores = goleadores,
                Asistentes = asistentes,
                EquipoMayorPresupuesto = equipoConMayorPresupuesto
            };
        }

    }
}
