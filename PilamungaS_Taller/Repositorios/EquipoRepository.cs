using Microsoft.AspNetCore.Razor.Language.Intermediate;
using PilamungaS_Taller.Data;
using PilamungaS_Taller.Models;

namespace PilamungaS_Taller.Repositorios
{
    public class EquipoRepository
    {
        private readonly PilamungaS_TallerContext _context;

        public EquipoRepository(PilamungaS_TallerContext context)
        {
            _context = context;
        }

        public IEnumerable<Equipo> DevuelveListadoEquipos2()
        {
            return _context.Equipos.ToList();
        }

        public Equipo DevuelveEquipoPorId(int id)
        {
            return _context.Equipos.Find(id);
        }

        public bool ActualizarEquipo(int id, Equipo equipo)
        {
            var equipoDb = _context.Equipos.Find(id);
            if (equipoDb == null) return false;

            equipoDb.PartidosGanados = equipo.PartidosGanados;
            equipoDb.PartidosEmpatados = equipo.PartidosEmpatados;
            equipoDb.PartidosPerdidos = equipo.PartidosPerdidos;

            _context.SaveChanges();
            return true;
        }
    }

}

