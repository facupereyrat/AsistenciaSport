using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsistenciaSport.BD.Migrations
{
    /// <inheritdoc />
    public partial class Protected : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asistencia_Miembros_MiembroId",
                table: "Asistencia");

            migrationBuilder.DropForeignKey(
                name: "FK_Cuotas_Administradores_AdministradorId",
                table: "Cuotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Miembros_Administradores_AdministradorId",
                table: "Miembros");

            migrationBuilder.DropIndex(
                name: "IX_Cuotas_AdministradorId",
                table: "Cuotas");

            migrationBuilder.RenameColumn(
                name: "AdministradorId",
                table: "Cuotas",
                newName: "IdMiembro");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencia_Miembros_MiembroId",
                table: "Asistencia",
                column: "MiembroId",
                principalTable: "Miembros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Miembros_Administradores_AdministradorId",
                table: "Miembros",
                column: "AdministradorId",
                principalTable: "Administradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asistencia_Miembros_MiembroId",
                table: "Asistencia");

            migrationBuilder.DropForeignKey(
                name: "FK_Miembros_Administradores_AdministradorId",
                table: "Miembros");

            migrationBuilder.RenameColumn(
                name: "IdMiembro",
                table: "Cuotas",
                newName: "AdministradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuotas_AdministradorId",
                table: "Cuotas",
                column: "AdministradorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencia_Miembros_MiembroId",
                table: "Asistencia",
                column: "MiembroId",
                principalTable: "Miembros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cuotas_Administradores_AdministradorId",
                table: "Cuotas",
                column: "AdministradorId",
                principalTable: "Administradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Miembros_Administradores_AdministradorId",
                table: "Miembros",
                column: "AdministradorId",
                principalTable: "Administradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
