using Microsoft.AspNetCore.Razor.Language.Intermediate;
using PilamungaS_Taller.Models;

namespace PilamungaS_Taller.Repositorios
{

    public class EquipoRepository
    {
        public static IEnumerable<Equipo> Equipos; //agregamos static para que se conserve los datos
        public EquipoRepository()
        {
            if (Equipos == null)
            {
                Equipos = DevuelveListadoEquipos();
            }
        }
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "Liga de quito",
                //PartidosJugados = 10,comentamos los partidos jugados porque ya
                //en Equipo sumamos los ganados, perdidos y empatados para saber los jugados
                PartidosGanados = 3,
                PartidosEmpatados = 2,
                PartidosPerdidos = 1,
                Descripcion = "Conocida como LDU Quito, es uno de los clubes más exitosos del país," +
                " con títulos nacionales e internacionales, incluyendo la Copa Libertadores.",
                Logo = "/img/ldu.png"
            };


            Equipo bsc = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona",
                //PartidosJugados = 10,
                PartidosGanados = 5,
                PartidosEmpatados = 0,
                PartidosPerdidos = 1,
                Descripcion = "Uno de los clubes más populares y exitosos de Ecuador, con múltiples" +
                " títulos nacionales e internacionales. Su hinchada, conocida como los amarillos, es muy apasionada.",
                Logo = "/img/bsc.png"
            };

            Equipo cnb = new Equipo
            {
                Id = 3,
                Nombre = "Cuniburo/Vinotinto",
                //PartidosJugados = 10,
                PartidosGanados = 4,
                PartidosEmpatados = 3,
                PartidosPerdidos = 1,
                Descripcion = "Este equipo, anteriormente conocido como Cuniburo, ascendió por" +
                " primera vez a la Serie A en 2025, buscando dejar su huella en la máxima categoría.",
                Logo = "/img/cnb.png"
            };
            Equipo uct = new Equipo
            {
                Id = 4,
                Nombre = "U.Catolica",
                //PartidosJugados = 10,
                PartidosGanados = 3,
                PartidosEmpatados = 3,
                PartidosPerdidos = 1,
                Descripcion = "Representando a la capital, la Chatoleí ha sido un equipo que ha" +
                " luchado por mantenerse en la Serie A y busca consolidarse en la élite del fútbol ecuatoriano.",
                Logo = "/img/uct.png"
            };
            Equipo inv = new Equipo
            {
                Id = 5,
                Nombre = "Independiente",
                //PartidosJugados = 10,
                PartidosGanados = 3,
                PartidosEmpatados = 3,
                PartidosPerdidos = 1,
                Descripcion = "Ubicado en Sangolquí, Independiente ha ganado reconocimiento por su" +
                " sólida formación de jugadores y buenas actuaciones en competiciones internacionales.",
                Logo = "/img/inv.png"
            };
            Equipo lbt = new Equipo
            {
                Id = 6,
                Nombre = "Libertad",
                //PartidosJugados = 10,
                PartidosGanados = 3,
                PartidosEmpatados = 2,
                PartidosPerdidos = 2,
                Descripcion = "Representante de Loja, Libertad ha sido un equipo que ha luchado por" +
                " mantenerse en la Serie A y busca consolidarse en la élite del fútbol ecuatoriano.​",
                Logo = "/img/lbt.jpeg"
            };
            Equipo dcu = new Equipo
            {
                Id = 7,
                Nombre = "Dep.Cuenca",
                //PartidosJugados = 10,
                PartidosGanados = 3,
                PartidosEmpatados = 1,
                PartidosPerdidos = 4,
                Descripcion = "Fundado en 1971, el Expreso Austral ha sido un equipo competitivo" +
                " en la Serie A, con una hinchada fiel y estadios con gran ambiente.",
                Logo = "/img/dcu.png"
            };
            Equipo orn = new Equipo
            {
                Id = 8,
                Nombre = "Orense",
                //PartidosJugados = 10,
                PartidosGanados = 3,
                PartidosEmpatados = 1,
                PartidosPerdidos = 3,
                Descripcion = "Representante de Machala, Orense ha sido un equipo que ha luchado" +
                " por mantenerse en la Serie A y busca consolidarse en la élite del fútbol ecuatoriano.",
                Logo = "/img/orn.png"
            };
            Equipo msr = new Equipo
            {
                Id = 9,
                Nombre = "MushucRuna",
                //PartidosJugados = 10,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 2,
                Descripcion = "Equipo con sede en Ambato, Mushuc Runa ha sido conocido por su lucha" +
                " y esfuerzo en la Serie A, buscando siempre mejorar su rendimiento.",
                Logo = "/img/msr.png"
            };
            Equipo auc = new Equipo
            {
                Id = 10,
                Nombre = "Aucas",
                //PartidosJugados = 10,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 2,
                Descripcion = "Fundado en 1945, Aucas es un club con sede en el sur de Quito. Ha tenido participaciones" +
                " destacadas en la Serie A y busca consolidarse entre los mejores del país.",
                Logo = "/img/auc.png"
            };
            Equipo mca = new Equipo
            {
                Id = 11,
                Nombre = "Macara",
                //PartidosJugados = 10,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 3,
                Descripcion = "Fundado en 1948, Macará es un equipo con sede en Ambato que ha tenido participaciones" +
                " destacadas en la Serie A y busca volver a sus épocas de gloria.",
                Logo = "/img/mca.png"
            };
            Equipo mnt = new Equipo
            {
                Id = 12,
                Nombre = "Manta",
                //PartidosJugados = 10,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 3,
                Descripcion = "Tras su ascenso, Manta regresa a la Serie A con el objetivo de mantenerse y competir al más alto nivel.",
                Logo = "/img/mnt.png"
            };
            Equipo tuv = new Equipo
            {
                Id = 13,
                Nombre = "TecnicoUniversitario",
                //PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 3,
                PartidosPerdidos = 4,
                Descripcion = "Fundado en 2008, El Rodillo del Tungurahua ha sido un equipo que ha luchado" +
                " por mantenerse en la Serie A y busca consolidarse en la élite del fútbol ecuatoriano.",
                Logo = "/img/tuv.png"
            };
            Equipo emc = new Equipo
            {
                Id = 14,
                Nombre = "Emelec",
                //PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 3,
                PartidosPerdidos = 3,
                Descripcion = "Fundado en 1929, Emelec es uno de los clubes más laureados de Ecuador," +
                " con una gran hinchada y rivalidad histórica con Barcelona SC.​",
                Logo = "/img/emc.png"
            };
            Equipo del = new Equipo
            {
                Id = 15,
                Nombre = "Delfin",
                //PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 3,
                PartidosPerdidos = 4,
                Descripcion = "Representante de la ciudad de Manta, Delfín ha sido protagonista en" +
                " los últimos años, logrando títulos y destacadas actuaciones en competiciones internacionales.",
                Logo = "/img/del.png"
            };
            Equipo nac = new Equipo
            {
                Id = 16,
                Nombre = "Nacional",
                //PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 2,
                PartidosPerdidos = 4,
                Descripcion = "Con sede en Quito, El Nacional ha sido históricamente uno de los clubes" +
                " más importantes del país, con una rica historia y múltiples títulos.",
                Logo = "/img/nac.png"
            };
            equipos.Add(bsc);
            equipos.Add(ldu);
            equipos.Add(cnb);
            equipos.Add(uct);
            equipos.Add(inv);
            equipos.Add(lbt);
            equipos.Add(dcu);
            equipos.Add(orn);
            equipos.Add(msr);
            equipos.Add(auc);
            equipos.Add(mca);
            equipos.Add(mnt);
            equipos.Add(tuv);
            equipos.Add(emc);
            equipos.Add(del);
            equipos.Add(nac);
            return equipos;
        }

        public IEnumerable<Equipo> DevuelveListadoEquipos2() //Devuelve la lista actualizada
        {
            return Equipos;
        }

        public Equipo DevuelveEquipoPorId(int Id)
        {
           
            return Equipos.FirstOrDefault(e=> e.Id == Id); //utilizamos para buscar el primer equipo con el mismo id 
        }

        public bool ActualizarEquipo(int Id,Equipo equipo)
        {
            var equipos = DevuelveEquipoPorId(Id);
            equipos.PartidosGanados = equipo.PartidosGanados;
            //equipos.PartidosJugados = equipo.PartidosJugados; esta parte tambien ya que no es necesario y para que no nos de error
            equipos.PartidosEmpatados = equipo.PartidosEmpatados;
            equipos.PartidosPerdidos= equipo.PartidosPerdidos;
            
            return true;
        }
    }

}

