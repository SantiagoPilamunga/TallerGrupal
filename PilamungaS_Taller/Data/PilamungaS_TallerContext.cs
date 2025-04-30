using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PilamungaS_Taller.Models;

namespace PilamungaS_Taller.Data
{
    public class PilamungaS_TallerContext : DbContext
    {
        public PilamungaS_TallerContext (DbContextOptions<PilamungaS_TallerContext> options)
            : base(options)
        {
        }

        public DbSet<PilamungaS_Taller.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<PilamungaS_Taller.Models.Jugador> Jugador { get; set; } = default!;
    }
}
