using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GSGreenCycle.Migrations
{
    /// <inheritdoc />
    public partial class criacaoDaEntidadeBicicletas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BicicletaId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BicicletaModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BicicletaModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BicicletaModelReservaModel",
                columns: table => new
                {
                    BicicletasId = table.Column<int>(type: "int", nullable: false),
                    ReservaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BicicletaModelReservaModel", x => new { x.BicicletasId, x.ReservaId });
                    table.ForeignKey(
                        name: "FK_BicicletaModelReservaModel_BicicletaModel_BicicletasId",
                        column: x => x.BicicletasId,
                        principalTable: "BicicletaModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BicicletaModelReservaModel_Reservas_ReservaId",
                        column: x => x.ReservaId,
                        principalTable: "Reservas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_BicicletaId",
                table: "Usuarios",
                column: "BicicletaId",
                unique: true,
                filter: "[BicicletaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BicicletaModelReservaModel_ReservaId",
                table: "BicicletaModelReservaModel",
                column: "ReservaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_BicicletaModel_BicicletaId",
                table: "Usuarios",
                column: "BicicletaId",
                principalTable: "BicicletaModel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_BicicletaModel_BicicletaId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "BicicletaModelReservaModel");

            migrationBuilder.DropTable(
                name: "BicicletaModel");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_BicicletaId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "BicicletaId",
                table: "Usuarios");
        }
    }
}
