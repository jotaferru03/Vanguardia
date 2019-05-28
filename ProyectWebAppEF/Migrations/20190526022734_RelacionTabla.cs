using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectWebAppEF.Migrations
{
    public partial class RelacionTabla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AplicacionTrabajoIdUsuario",
                schema: "dbo",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EducacionUsuarioIdUsuario",
                schema: "dbo",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AplicacionTrabajoIdPublicacionTrabajo",
                schema: "dbo",
                table: "PublicacionTrabajo",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PublicacionTrabajoIdEmpresa",
                schema: "dbo",
                table: "Empresa",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_PublicacionTrabajo_IdEmpresa",
                schema: "dbo",
                table: "PublicacionTrabajo",
                column: "IdEmpresa");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_EducacionUsuario_IdUsuario",
                schema: "dbo",
                table: "EducacionUsuario",
                column: "IdUsuario");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_AplicacionTrabajo_IdPublicacionTrabajo",
                schema: "dbo",
                table: "AplicacionTrabajo",
                column: "IdPublicacionTrabajo");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_AplicacionTrabajo_IdUsuario",
                schema: "dbo",
                table: "AplicacionTrabajo",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_AplicacionTrabajoIdUsuario",
                schema: "dbo",
                table: "Usuario",
                column: "AplicacionTrabajoIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_EducacionUsuarioIdUsuario",
                schema: "dbo",
                table: "Usuario",
                column: "EducacionUsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_PublicacionTrabajo_AplicacionTrabajoIdPublicacionTrabajo",
                schema: "dbo",
                table: "PublicacionTrabajo",
                column: "AplicacionTrabajoIdPublicacionTrabajo");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_PublicacionTrabajoIdEmpresa",
                schema: "dbo",
                table: "Empresa",
                column: "PublicacionTrabajoIdEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_PublicacionTrabajo_PublicacionTrabajoIdEmpresa",
                schema: "dbo",
                table: "Empresa",
                column: "PublicacionTrabajoIdEmpresa",
                principalSchema: "dbo",
                principalTable: "PublicacionTrabajo",
                principalColumn: "IdEmpresa",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PublicacionTrabajo_AplicacionTrabajo_AplicacionTrabajoIdPublicacionTrabajo",
                schema: "dbo",
                table: "PublicacionTrabajo",
                column: "AplicacionTrabajoIdPublicacionTrabajo",
                principalSchema: "dbo",
                principalTable: "AplicacionTrabajo",
                principalColumn: "IdPublicacionTrabajo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_AplicacionTrabajo_AplicacionTrabajoIdUsuario",
                schema: "dbo",
                table: "Usuario",
                column: "AplicacionTrabajoIdUsuario",
                principalSchema: "dbo",
                principalTable: "AplicacionTrabajo",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_EducacionUsuario_EducacionUsuarioIdUsuario",
                schema: "dbo",
                table: "Usuario",
                column: "EducacionUsuarioIdUsuario",
                principalSchema: "dbo",
                principalTable: "EducacionUsuario",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_PublicacionTrabajo_PublicacionTrabajoIdEmpresa",
                schema: "dbo",
                table: "Empresa");

            migrationBuilder.DropForeignKey(
                name: "FK_PublicacionTrabajo_AplicacionTrabajo_AplicacionTrabajoIdPublicacionTrabajo",
                schema: "dbo",
                table: "PublicacionTrabajo");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_AplicacionTrabajo_AplicacionTrabajoIdUsuario",
                schema: "dbo",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_EducacionUsuario_EducacionUsuarioIdUsuario",
                schema: "dbo",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_AplicacionTrabajoIdUsuario",
                schema: "dbo",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_EducacionUsuarioIdUsuario",
                schema: "dbo",
                table: "Usuario");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_PublicacionTrabajo_IdEmpresa",
                schema: "dbo",
                table: "PublicacionTrabajo");

            migrationBuilder.DropIndex(
                name: "IX_PublicacionTrabajo_AplicacionTrabajoIdPublicacionTrabajo",
                schema: "dbo",
                table: "PublicacionTrabajo");

            migrationBuilder.DropIndex(
                name: "IX_Empresa_PublicacionTrabajoIdEmpresa",
                schema: "dbo",
                table: "Empresa");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_EducacionUsuario_IdUsuario",
                schema: "dbo",
                table: "EducacionUsuario");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_AplicacionTrabajo_IdPublicacionTrabajo",
                schema: "dbo",
                table: "AplicacionTrabajo");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_AplicacionTrabajo_IdUsuario",
                schema: "dbo",
                table: "AplicacionTrabajo");

            migrationBuilder.DropColumn(
                name: "AplicacionTrabajoIdUsuario",
                schema: "dbo",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "EducacionUsuarioIdUsuario",
                schema: "dbo",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "AplicacionTrabajoIdPublicacionTrabajo",
                schema: "dbo",
                table: "PublicacionTrabajo");

            migrationBuilder.DropColumn(
                name: "PublicacionTrabajoIdEmpresa",
                schema: "dbo",
                table: "Empresa");
        }
    }
}
