using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsistenciaSport.BD.Migrations
{
    /// <inheritdoc />
    public partial class ModifClaveFor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuotas_Administradores_AdministradorId",
                table: "Cuotas");

            migrationBuilder.DropIndex(
                name: "IX_Cuotas_AdministradorId",
                table: "Cuotas");

            migrationBuilder.DropColumn(
                name: "AdministradorId",
                table: "Cuotas");

            migrationBuilder.DropColumn(
                name: "IdAdministrador",
                table: "Cuotas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdministradorId",
                table: "Cuotas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdAdministrador",
                table: "Cuotas",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
