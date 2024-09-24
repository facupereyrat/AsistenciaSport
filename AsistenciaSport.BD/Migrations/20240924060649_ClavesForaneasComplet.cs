using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsistenciaSport.BD.Migrations
{
    /// <inheritdoc />
    public partial class ClavesForaneasComplet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdministradorId",
                table: "Cuotas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MiembroId",
                table: "Cuotas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MiembroId",
                table: "Asistencia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cuotas_AdministradorId",
                table: "Cuotas",
                column: "AdministradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuotas_MiembroId",
                table: "Cuotas",
                column: "MiembroId");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_MiembroId",
                table: "Asistencia",
                column: "MiembroId");

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
                name: "FK_Cuotas_Miembros_MiembroId",
                table: "Cuotas",
                column: "MiembroId",
                principalTable: "Miembros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asistencia_Miembros_MiembroId",
                table: "Asistencia");

            migrationBuilder.DropForeignKey(
                name: "FK_Cuotas_Administradores_AdministradorId",
                table: "Cuotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Cuotas_Miembros_MiembroId",
                table: "Cuotas");

            migrationBuilder.DropIndex(
                name: "IX_Cuotas_AdministradorId",
                table: "Cuotas");

            migrationBuilder.DropIndex(
                name: "IX_Cuotas_MiembroId",
                table: "Cuotas");

            migrationBuilder.DropIndex(
                name: "IX_Asistencia_MiembroId",
                table: "Asistencia");

            migrationBuilder.DropColumn(
                name: "AdministradorId",
                table: "Cuotas");

            migrationBuilder.DropColumn(
                name: "MiembroId",
                table: "Cuotas");

            migrationBuilder.DropColumn(
                name: "MiembroId",
                table: "Asistencia");
        }
    }
}
