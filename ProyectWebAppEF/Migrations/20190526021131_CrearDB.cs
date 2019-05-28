using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectWebAppEF.Migrations
{
    public partial class CrearDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "AplicacionTrabajo",
                schema: "dbo",
                columns: table => new
                {
                    Idaplicacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AplicacionTrabajo", x => x.Idaplicacion);
                });

            migrationBuilder.CreateTable(
                name: "EducacionUsuario",
                schema: "dbo",
                columns: table => new
                {
                    IdEducacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DondeEstudio = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "Date", nullable: false),
                    Descripcion = table.Column<string>(type: "Text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducacionUsuario", x => x.IdEducacion);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                schema: "dbo",
                columns: table => new
                {
                    Idempresa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RTN = table.Column<string>(type: "varchar", maxLength: 50, nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Mision = table.Column<string>(type: "Text", nullable: true),
                    Vision = table.Column<string>(type: "Text", nullable: true),
                    SobreNosotros = table.Column<string>(type: "Text", nullable: true),
                    Contacto = table.Column<int>(nullable: false),
                    Correo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Contrasenia = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Idempresa);
                });

            migrationBuilder.CreateTable(
                name: "PublicacionTrabajo",
                schema: "dbo",
                columns: table => new
                {
                    IdPropuesta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PuestoTrabajo = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    Descripcion = table.Column<string>(type: "Text", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicacionTrabajo", x => x.IdPropuesta);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                schema: "dbo",
                columns: table => new
                {
                    Idusuario = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_Usuario", x => x.Idusuario);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AplicacionTrabajo",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "EducacionUsuario",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Empresa",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PublicacionTrabajo",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Usuario",
                schema: "dbo");
        }
    }
}
