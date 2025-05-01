using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PilamungaS_Taller.Migrations
{
    /// <inheritdoc />
    public partial class Migracionnueva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PartidosGanados = table.Column<int>(type: "int", nullable: false),
                    PartidosEmpatados = table.Column<int>(type: "int", nullable: false),
                    PartidosPerdidos = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jugador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroCamiseta = table.Column<int>(type: "int", nullable: false),
                    Goles = table.Column<int>(type: "int", nullable: false),
                    AsistenciasTotales = table.Column<int>(type: "int", nullable: false),
                    Sueldo = table.Column<float>(type: "real", nullable: false),
                    EquipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jugador_Equipo_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Equipo",
                columns: new[] { "Id", "Descripcion", "Logo", "Nombre", "PartidosEmpatados", "PartidosGanados", "PartidosPerdidos" },
                values: new object[,]
                {
                    { 1, "Conocida como LDU Quito, es uno de los clubes más exitosos del país, con títulos nacionales e internacionales, incluyendo la Copa Libertadores.", "/img/ldu.png", "Liga de quito", 2, 3, 1 },
                    { 2, "Uno de los clubes más populares y exitosos de Ecuador, con múltiples títulos nacionales e internacionales. Su hinchada, conocida como los amarillos, es muy apasionada.", "/img/bsc.png", "Barcelona", 0, 5, 1 },
                    { 3, "Este equipo, anteriormente conocido como Cuniburo, ascendió por primera vez a la Serie A en 2025, buscando dejar su huella en la máxima categoría.", "/img/cnb.png", "Cuniburo/Vinotinto", 3, 4, 1 },
                    { 4, "Representando a la capital, la Chatoleí ha sido un equipo que ha luchado por mantenerse en la Serie A y busca consolidarse en la élite del fútbol ecuatoriano.", "/img/uct.png", "U.Catolica", 3, 3, 1 },
                    { 5, "Ubicado en Sangolquí, Independiente ha ganado reconocimiento por su sólida formación de jugadores y buenas actuaciones en competiciones internacionales.", "/img/inv.png", "Independiente", 3, 3, 1 },
                    { 6, "Representante de Loja, Libertad ha sido un equipo que ha luchado por mantenerse en la Serie A y busca consolidarse en la élite del fútbol ecuatoriano.​", "/img/lbt.jpeg", "Libertad", 2, 3, 2 },
                    { 7, "Fundado en 1971, el Expreso Austral ha sido un equipo competitivo en la Serie A, con una hinchada fiel y estadios con gran ambiente.", "/img/dcu.png", "Dep.Cuenca", 1, 3, 4 },
                    { 8, "Representante de Machala, Orense ha sido un equipo que ha luchado por mantenerse en la Serie A y busca consolidarse en la élite del fútbol ecuatoriano.", "/img/orn.png", "Orense", 1, 3, 3 },
                    { 9, "Equipo con sede en Ambato, Mushuc Runa ha sido conocido por su lucha y esfuerzo en la Serie A, buscando siempre mejorar su rendimiento.", "/img/msr.png", "MushucRuna", 3, 2, 2 },
                    { 10, "Fundado en 1945, Aucas es un club con sede en el sur de Quito. Ha tenido participaciones destacadas en la Serie A y busca consolidarse entre los mejores del país.", "/img/auc.png", "Aucas", 3, 2, 2 },
                    { 11, "Fundado en 1948, Macará es un equipo con sede en Ambato que ha tenido participaciones destacadas en la Serie A y busca volver a sus épocas de gloria.", "/img/mca.png", "Macara", 3, 2, 3 },
                    { 12, "Tras su ascenso, Manta regresa a la Serie A con el objetivo de mantenerse y competir al más alto nivel.", "/img/mnt.png", "Manta", 3, 2, 3 },
                    { 13, "Fundado en 2008, El Rodillo del Tungurahua ha sido un equipo que ha luchado por mantenerse en la Serie A y busca consolidarse en la élite del fútbol ecuatoriano.", "/img/tuv.png", "TecnicoUniversitario", 3, 1, 4 },
                    { 14, "Fundado en 1929, Emelec es uno de los clubes más laureados de Ecuador, con una gran hinchada y rivalidad histórica con Barcelona SC.​", "/img/emc.png", "Emelec", 3, 1, 3 },
                    { 15, "Representante de la ciudad de Manta, Delfín ha sido protagonista en los últimos años, logrando títulos y destacadas actuaciones en competiciones internacionales.", "/img/del.png", "Delfin", 3, 1, 4 },
                    { 16, "Con sede en Quito, El Nacional ha sido históricamente uno de los clubes más importantes del país, con una rica historia y múltiples títulos.", "/img/nac.png", "Nacional", 2, 1, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jugador_EquipoId",
                table: "Jugador",
                column: "EquipoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jugador");

            migrationBuilder.DropTable(
                name: "Equipo");
        }
    }
}
