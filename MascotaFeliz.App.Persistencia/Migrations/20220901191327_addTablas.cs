using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MascotaFeliz.App.Persistencia.Migrations
{
    public partial class addTablas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Correo",
                table: "Personas",
                type: "nvarchar(65)",
                maxLength: 65,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tarjeta",
                table: "Personas",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Historias",
                columns: table => new
                {
                    HistoriaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Diagnostico = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Medicamentos = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historias", x => x.HistoriaID);
                });

            migrationBuilder.CreateTable(
                name: "Mascotas",
                columns: table => new
                {
                    MascotaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicoID = table.Column<int>(type: "int", nullable: false),
                    HistoriaID = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Especie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Raza = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: true),
                    DuenoPersonaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascotas", x => x.MascotaID);
                    table.ForeignKey(
                        name: "FK_Mascotas_Historias_HistoriaID",
                        column: x => x.HistoriaID,
                        principalTable: "Historias",
                        principalColumn: "HistoriaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mascotas_Personas_DuenoPersonaID",
                        column: x => x.DuenoPersonaID,
                        principalTable: "Personas",
                        principalColumn: "PersonaID");
                    table.ForeignKey(
                        name: "FK_Mascotas_Personas_MedicoID",
                        column: x => x.MedicoID,
                        principalTable: "Personas",
                        principalColumn: "PersonaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visitas",
                columns: table => new
                {
                    VisitaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicoID = table.Column<int>(type: "int", nullable: false),
                    FechaVisita = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Temperatura = table.Column<float>(type: "real", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    FrecuenciaCardiaca = table.Column<int>(type: "int", nullable: false),
                    FrecuenciaRespiratoria = table.Column<int>(type: "int", nullable: false),
                    EstadoAnimo = table.Column<int>(type: "int", nullable: true),
                    Recomendacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HistoriaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitas", x => x.VisitaID);
                    table.ForeignKey(
                        name: "FK_Visitas_Historias_HistoriaID",
                        column: x => x.HistoriaID,
                        principalTable: "Historias",
                        principalColumn: "HistoriaID");
                    table.ForeignKey(
                        name: "FK_Visitas_Personas_MedicoID",
                        column: x => x.MedicoID,
                        principalTable: "Personas",
                        principalColumn: "PersonaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_DuenoPersonaID",
                table: "Mascotas",
                column: "DuenoPersonaID");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_HistoriaID",
                table: "Mascotas",
                column: "HistoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_MedicoID",
                table: "Mascotas",
                column: "MedicoID");

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_HistoriaID",
                table: "Visitas",
                column: "HistoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_MedicoID",
                table: "Visitas",
                column: "MedicoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mascotas");

            migrationBuilder.DropTable(
                name: "Visitas");

            migrationBuilder.DropTable(
                name: "Historias");

            migrationBuilder.DropColumn(
                name: "Correo",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Tarjeta",
                table: "Personas");
        }
    }
}
