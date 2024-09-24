using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsistenciaSport.BD.Migrations
{
    /// <inheritdoc />
    public partial class ModificacionMensajesFuturoFront : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuotas_Miembros_MiembroId",
                table: "Cuotas");

            migrationBuilder.DropIndex(
                name: "IX_Cuotas_MiembroId",
                table: "Cuotas");

            migrationBuilder.RenameColumn(
                name: "MiembroId",
                table: "Cuotas",
                newName: "IdAdministrador");

            migrationBuilder.RenameColumn(
                name: "IdMiembro",
                table: "Cuotas",
                newName: "AdministradorId");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Miembros",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Miembros",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Cuotas_AdministradorId",
                table: "Cuotas",
                column: "AdministradorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuotas_Administradores_AdministradorId",
                table: "Cuotas",
                column: "AdministradorId",
                principalTable: "Administradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuotas_Administradores_AdministradorId",
                table: "Cuotas");

            migrationBuilder.DropIndex(
                name: "IX_Cuotas_AdministradorId",
                table: "Cuotas");

            migrationBuilder.RenameColumn(
                name: "IdAdministrador",
                table: "Cuotas",
                newName: "MiembroId");

            migrationBuilder.RenameColumn(
                name: "AdministradorId",
                table: "Cuotas",
                newName: "IdMiembro");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Miembros",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Miembros",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.CreateIndex(
                name: "IX_Cuotas_MiembroId",
                table: "Cuotas",
                column: "MiembroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuotas_Miembros_MiembroId",
                table: "Cuotas",
                column: "MiembroId",
                principalTable: "Miembros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
