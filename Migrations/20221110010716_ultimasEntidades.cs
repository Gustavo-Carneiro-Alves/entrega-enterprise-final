using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GSGreenCycle.Migrations
{
    /// <inheritdoc />
    public partial class ultimasEntidades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BicicletaModelReservaModel_Reservas_ReservaId",
                table: "BicicletaModelReservaModel");

            migrationBuilder.RenameColumn(
                name: "ReservaId",
                table: "BicicletaModelReservaModel",
                newName: "ReservasId");

            migrationBuilder.RenameIndex(
                name: "IX_BicicletaModelReservaModel_ReservaId",
                table: "BicicletaModelReservaModel",
                newName: "IX_BicicletaModelReservaModel_ReservasId");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Bicicletas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Bicicletas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Bicicletas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaModelId",
                table: "Bicicletas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cnpj = table.Column<int>(type: "int", nullable: false),
                    Telefone = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patinetes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpresaModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patinetes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patinetes_Empresas_EmpresaModelId",
                        column: x => x.EmpresaModelId,
                        principalTable: "Empresas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Patins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpresaModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patins_Empresas_EmpresaModelId",
                        column: x => x.EmpresaModelId,
                        principalTable: "Empresas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bicicletas_EmpresaModelId",
                table: "Bicicletas",
                column: "EmpresaModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Patinetes_EmpresaModelId",
                table: "Patinetes",
                column: "EmpresaModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Patins_EmpresaModelId",
                table: "Patins",
                column: "EmpresaModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_BicicletaModelReservaModel_Reservas_ReservasId",
                table: "BicicletaModelReservaModel",
                column: "ReservasId",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bicicletas_Empresas_EmpresaModelId",
                table: "Bicicletas",
                column: "EmpresaModelId",
                principalTable: "Empresas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BicicletaModelReservaModel_Reservas_ReservasId",
                table: "BicicletaModelReservaModel");

            migrationBuilder.DropForeignKey(
                name: "FK_Bicicletas_Empresas_EmpresaModelId",
                table: "Bicicletas");

            migrationBuilder.DropTable(
                name: "Patinetes");

            migrationBuilder.DropTable(
                name: "Patins");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropIndex(
                name: "IX_Bicicletas_EmpresaModelId",
                table: "Bicicletas");

            migrationBuilder.DropColumn(
                name: "EmpresaModelId",
                table: "Bicicletas");

            migrationBuilder.RenameColumn(
                name: "ReservasId",
                table: "BicicletaModelReservaModel",
                newName: "ReservaId");

            migrationBuilder.RenameIndex(
                name: "IX_BicicletaModelReservaModel_ReservasId",
                table: "BicicletaModelReservaModel",
                newName: "IX_BicicletaModelReservaModel_ReservaId");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Bicicletas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Bicicletas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Bicicletas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_BicicletaModelReservaModel_Reservas_ReservaId",
                table: "BicicletaModelReservaModel",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
