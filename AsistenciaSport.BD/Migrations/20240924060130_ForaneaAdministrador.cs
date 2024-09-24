using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsistenciaSport.BD.Migrations
{
    /// <inheritdoc />
    public partial class ForaneaAdministrador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdministradorId",
                table: "Miembros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Miembros_AdministradorId",
                table: "Miembros",
                column: "AdministradorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Miembros_Administradores_AdministradorId",
                table: "Miembros",
                column: "AdministradorId",
                principalTable: "Administradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Miembros_Administradores_AdministradorId",
                table: "Miembros");

            migrationBuilder.DropIndex(
                name: "IX_Miembros_AdministradorId",
                table: "Miembros");

            migrationBuilder.DropColumn(
                name: "AdministradorId",
                table: "Miembros");
        }
    }
}
