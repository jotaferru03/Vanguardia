using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyextoDAVWebApp.Migrations
{
    public partial class BD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                schema: "dbo",
                table: "Usuario");

            migrationBuilder.RenameTable(
                name: "Usuario",
                schema: "dbo",
                newName: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "ReclutamientoTrabajos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdAplicacionTrabajo",
                table: "ReclutamientoTrabajos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "ReclutamientoTrabajos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "OcupacionUsuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdReclutamientoTrabajo",
                table: "NombreTrabajos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReclutamientoTrabajoId",
                table: "NombreTrabajos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "EducacionUsuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdReclutamientoTrabajo",
                table: "Aplicaciontrabajos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "Aplicaciontrabajos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "PrimerNombre",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrimerApellido",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cuidad",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Correo",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Contrasenia",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AplicacionTrabajoId",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EducacionUsuarioId",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OcupacionUsuarioId",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ReclutamientoTrabajos_EmpresaId",
                table: "ReclutamientoTrabajos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_NombreTrabajos_ReclutamientoTrabajoId",
                table: "NombreTrabajos",
                column: "ReclutamientoTrabajoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_AplicacionTrabajoId",
                table: "Usuarios",
                column: "AplicacionTrabajoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EducacionUsuarioId",
                table: "Usuarios",
                column: "EducacionUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_OcupacionUsuarioId",
                table: "Usuarios",
                column: "OcupacionUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_NombreTrabajos_ReclutamientoTrabajos_ReclutamientoTrabajoId",
                table: "NombreTrabajos",
                column: "ReclutamientoTrabajoId",
                principalTable: "ReclutamientoTrabajos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReclutamientoTrabajos_Empresas_EmpresaId",
                table: "ReclutamientoTrabajos",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Aplicaciontrabajos_AplicacionTrabajoId",
                table: "Usuarios",
                column: "AplicacionTrabajoId",
                principalTable: "Aplicaciontrabajos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_EducacionUsuarios_EducacionUsuarioId",
                table: "Usuarios",
                column: "EducacionUsuarioId",
                principalTable: "EducacionUsuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_OcupacionUsuarios_OcupacionUsuarioId",
                table: "Usuarios",
                column: "OcupacionUsuarioId",
                principalTable: "OcupacionUsuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NombreTrabajos_ReclutamientoTrabajos_ReclutamientoTrabajoId",
                table: "NombreTrabajos");

            migrationBuilder.DropForeignKey(
                name: "FK_ReclutamientoTrabajos_Empresas_EmpresaId",
                table: "ReclutamientoTrabajos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Aplicaciontrabajos_AplicacionTrabajoId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_EducacionUsuarios_EducacionUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_OcupacionUsuarios_OcupacionUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_ReclutamientoTrabajos_EmpresaId",
                table: "ReclutamientoTrabajos");

            migrationBuilder.DropIndex(
                name: "IX_NombreTrabajos_ReclutamientoTrabajoId",
                table: "NombreTrabajos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_AplicacionTrabajoId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_EducacionUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_OcupacionUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "ReclutamientoTrabajos");

            migrationBuilder.DropColumn(
                name: "IdAplicacionTrabajo",
                table: "ReclutamientoTrabajos");

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "ReclutamientoTrabajos");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "OcupacionUsuarios");

            migrationBuilder.DropColumn(
                name: "IdReclutamientoTrabajo",
                table: "NombreTrabajos");

            migrationBuilder.DropColumn(
                name: "ReclutamientoTrabajoId",
                table: "NombreTrabajos");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "EducacionUsuarios");

            migrationBuilder.DropColumn(
                name: "IdReclutamientoTrabajo",
                table: "Aplicaciontrabajos");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Aplicaciontrabajos");

            migrationBuilder.DropColumn(
                name: "AplicacionTrabajoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "EducacionUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "OcupacionUsuarioId",
                table: "Usuarios");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario",
                newSchema: "dbo");

            migrationBuilder.AlterColumn<string>(
                name: "PrimerNombre",
                schema: "dbo",
                table: "Usuario",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrimerApellido",
                schema: "dbo",
                table: "Usuario",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                schema: "dbo",
                table: "Usuario",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cuidad",
                schema: "dbo",
                table: "Usuario",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Correo",
                schema: "dbo",
                table: "Usuario",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Contrasenia",
                schema: "dbo",
                table: "Usuario",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                schema: "dbo",
                table: "Usuario",
                column: "Id");
        }
    }
}
