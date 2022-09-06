using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MascotaFeliz.App.Persistencia.Migrations
{
    public partial class CambiosTablas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nombres",
                table: "Personas",
                newName: "Nombres");

            migrationBuilder.RenameColumn(
                name: "direccion",
                table: "Personas",
                newName: "Direccion");

            migrationBuilder.RenameColumn(
                name: "apellidos",
                table: "Personas",
                newName: "Apellidos");

            migrationBuilder.RenameColumn(
                name: "personaId",
                table: "Personas",
                newName: "PersonaID");

            migrationBuilder.AlterColumn<string>(
                name: "Nombres",
                table: "Personas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Personas",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Apellidos",
                table: "Personas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombres",
                table: "Personas",
                newName: "nombres");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Personas",
                newName: "direccion");

            migrationBuilder.RenameColumn(
                name: "Apellidos",
                table: "Personas",
                newName: "apellidos");

            migrationBuilder.RenameColumn(
                name: "PersonaID",
                table: "Personas",
                newName: "personaId");

            migrationBuilder.AlterColumn<string>(
                name: "nombres",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "direccion",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "apellidos",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
