using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GSGreenCycle.Migrations
{
    /// <inheritdoc />
    public partial class criacaoDaEntidadeBicicletas2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BicicletaModelReservaModel_BicicletaModel_BicicletasId",
                table: "BicicletaModelReservaModel");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_BicicletaModel_BicicletaId",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BicicletaModel",
                table: "BicicletaModel");

            migrationBuilder.RenameTable(
                name: "BicicletaModel",
                newName: "Bicicletas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bicicletas",
                table: "Bicicletas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BicicletaModelReservaModel_Bicicletas_BicicletasId",
                table: "BicicletaModelReservaModel",
                column: "BicicletasId",
                principalTable: "Bicicletas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Bicicletas_BicicletaId",
                table: "Usuarios",
                column: "BicicletaId",
                principalTable: "Bicicletas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BicicletaModelReservaModel_Bicicletas_BicicletasId",
                table: "BicicletaModelReservaModel");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Bicicletas_BicicletaId",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bicicletas",
                table: "Bicicletas");

            migrationBuilder.RenameTable(
                name: "Bicicletas",
                newName: "BicicletaModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BicicletaModel",
                table: "BicicletaModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BicicletaModelReservaModel_BicicletaModel_BicicletasId",
                table: "BicicletaModelReservaModel",
                column: "BicicletasId",
                principalTable: "BicicletaModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_BicicletaModel_BicicletaId",
                table: "Usuarios",
                column: "BicicletaId",
                principalTable: "BicicletaModel",
                principalColumn: "Id");
        }
    }
}
