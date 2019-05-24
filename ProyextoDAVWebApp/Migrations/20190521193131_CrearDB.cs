using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyextoDAVWebApp.Migrations
{
    public partial class CrearDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Usuario",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PrimerNombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    PrimerApellido = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Cuidad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Direccion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Telefono = table.Column<int>(nullable: false),
                    Correo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Contrasenia = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario",
                schema: "dbo");
        }
    }
}
