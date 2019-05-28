using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectWebAppEF.Migrations
{
    public partial class LlaveForania : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                schema: "dbo",
                table: "PublicacionTrabajo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                schema: "dbo",
                table: "EducacionUsuario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPublicacionTrabajo",
                schema: "dbo",
                table: "AplicacionTrabajo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                schema: "dbo",
                table: "AplicacionTrabajo",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                schema: "dbo",
                table: "PublicacionTrabajo");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                schema: "dbo",
                table: "EducacionUsuario");

            migrationBuilder.DropColumn(
                name: "IdPublicacionTrabajo",
                schema: "dbo",
                table: "AplicacionTrabajo");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                schema: "dbo",
                table: "AplicacionTrabajo");
        }
    }
}
