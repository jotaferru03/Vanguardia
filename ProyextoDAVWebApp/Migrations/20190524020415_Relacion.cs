using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyextoDAVWebApp.Migrations
{
    public partial class Relacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Aplicaciontrabajos_AplicacionTrabajoId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_EducacionUsuarios_EducacionUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_OcupacionUsuarios_OcupacionUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "OcupacionUsuarioId",
                schema: "dbo",
                table: "Usuario",
                newName: "OcupacionUsuarioIdUsuario");

            migrationBuilder.RenameColumn(
                name: "EducacionUsuarioId",
                schema: "dbo",
                table: "Usuario",
                newName: "EducacionUsuarioIdUsuario");

            migrationBuilder.RenameColumn(
                name: "AplicacionTrabajoId",
                schema: "dbo",
                table: "Usuario",
                newName: "AplicacionTrabajoIdUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_OcupacionUsuarioId",
                schema: "dbo",
                table: "Usuario",
                newName: "IX_Usuario_OcupacionUsuarioIdUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_EducacionUsuarioId",
                schema: "dbo",
                table: "Usuario",
                newName: "IX_Usuario_EducacionUsuarioIdUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_AplicacionTrabajoId",
                schema: "dbo",
                table: "Usuario",
                newName: "IX_Usuario_AplicacionTrabajoIdUsuario");

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

            migrationBuilder.AddUniqueConstraint(
                name: "AK_OcupacionUsuarios_IdUsuario",
                table: "OcupacionUsuarios",
                column: "IdUsuario");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_EducacionUsuarios_IdUsuario",
                table: "EducacionUsuarios",
                column: "IdUsuario");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Aplicaciontrabajos_IdUsuario",
                table: "Aplicaciontrabajos",
                column: "IdUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                schema: "dbo",
                table: "Usuario",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Aplicaciontrabajos_AplicacionTrabajoIdUsuario",
                schema: "dbo",
                table: "Usuario",
                column: "AplicacionTrabajoIdUsuario",
                principalTable: "Aplicaciontrabajos",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_EducacionUsuarios_EducacionUsuarioIdUsuario",
                schema: "dbo",
                table: "Usuario",
                column: "EducacionUsuarioIdUsuario",
                principalTable: "EducacionUsuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_OcupacionUsuarios_OcupacionUsuarioIdUsuario",
                schema: "dbo",
                table: "Usuario",
                column: "OcupacionUsuarioIdUsuario",
                principalTable: "OcupacionUsuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Aplicaciontrabajos_AplicacionTrabajoIdUsuario",
                schema: "dbo",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_EducacionUsuarios_EducacionUsuarioIdUsuario",
                schema: "dbo",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_OcupacionUsuarios_OcupacionUsuarioIdUsuario",
                schema: "dbo",
                table: "Usuario");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_OcupacionUsuarios_IdUsuario",
                table: "OcupacionUsuarios");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_EducacionUsuarios_IdUsuario",
                table: "EducacionUsuarios");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Aplicaciontrabajos_IdUsuario",
                table: "Aplicaciontrabajos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                schema: "dbo",
                table: "Usuario");

            migrationBuilder.RenameTable(
                name: "Usuario",
                schema: "dbo",
                newName: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "OcupacionUsuarioIdUsuario",
                table: "Usuarios",
                newName: "OcupacionUsuarioId");

            migrationBuilder.RenameColumn(
                name: "EducacionUsuarioIdUsuario",
                table: "Usuarios",
                newName: "EducacionUsuarioId");

            migrationBuilder.RenameColumn(
                name: "AplicacionTrabajoIdUsuario",
                table: "Usuarios",
                newName: "AplicacionTrabajoId");

            migrationBuilder.RenameIndex(
                name: "IX_Usuario_OcupacionUsuarioIdUsuario",
                table: "Usuarios",
                newName: "IX_Usuarios_OcupacionUsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Usuario_EducacionUsuarioIdUsuario",
                table: "Usuarios",
                newName: "IX_Usuarios_EducacionUsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Usuario_AplicacionTrabajoIdUsuario",
                table: "Usuarios",
                newName: "IX_Usuarios_AplicacionTrabajoId");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

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
    }
}
