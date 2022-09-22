using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MascotaFeliz.App.Persistencia.Migrations
{
    public partial class Inicialdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Duenos",
                columns: table => new
                {
                    DuenoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duenos", x => x.DuenoID);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    MedicoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Tarjeta = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.MedicoID);
                });

            migrationBuilder.CreateTable(
                name: "Mascotas",
                columns: table => new
                {
                    MascotaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Especie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Raza = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MedicoID = table.Column<int>(type: "int", nullable: false),
                    DuenoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascotas", x => x.MascotaID);
                    table.ForeignKey(
                        name: "FK_Mascotas_Duenos_DuenoID",
                        column: x => x.DuenoID,
                        principalTable: "Duenos",
                        principalColumn: "DuenoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mascotas_Medicos_MedicoID",
                        column: x => x.MedicoID,
                        principalTable: "Medicos",
                        principalColumn: "MedicoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Historias",
                columns: table => new
                {
                    HistoriaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Diagnostico = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Medicamentos = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MascotaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historias", x => x.HistoriaID);
                    table.ForeignKey(
                        name: "FK_Historias_Mascotas_MascotaID",
                        column: x => x.MascotaID,
                        principalTable: "Mascotas",
                        principalColumn: "MascotaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visitas",
                columns: table => new
                {
                    VisitaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaVisita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Temperatura = table.Column<float>(type: "real", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    FrecuenciaCardiaca = table.Column<int>(type: "int", nullable: false),
                    FrecuenciaRespiratoria = table.Column<int>(type: "int", nullable: false),
                    EstadoAnimo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recomendacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MedicoID = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Visitas_Medicos_MedicoID",
                        column: x => x.MedicoID,
                        principalTable: "Medicos",
                        principalColumn: "MedicoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Historias_MascotaID",
                table: "Historias",
                column: "MascotaID");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_DuenoID",
                table: "Mascotas",
                column: "DuenoID");

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
                name: "Visitas");

            migrationBuilder.DropTable(
                name: "Historias");

            migrationBuilder.DropTable(
                name: "Mascotas");

            migrationBuilder.DropTable(
                name: "Duenos");

            migrationBuilder.DropTable(
                name: "Medicos");
        }
    }
}
