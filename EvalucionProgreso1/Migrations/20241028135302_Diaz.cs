using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvalucionProgreso1.Migrations
{
    /// <inheritdoc />
    public partial class Diaz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Celular",
                columns: table => new
                {
                    IdCelular = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Año = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celular", x => x.IdCelular);
                });

            migrationBuilder.CreateTable(
                name: "Diaz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtributoDecimal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TieneBeca = table.Column<bool>(type: "bit", nullable: false),
                    IdCelular = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diaz", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diaz_Celular_IdCelular",
                        column: x => x.IdCelular,
                        principalTable: "Celular",
                        principalColumn: "IdCelular",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Celular_Id",
                table: "Celular",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Diaz_IdCelular",
                table: "Diaz",
                column: "IdCelular");

            migrationBuilder.AddForeignKey(
                name: "FK_Celular_Diaz_Id",
                table: "Celular",
                column: "Id",
                principalTable: "Diaz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Celular_Diaz_Id",
                table: "Celular");

            migrationBuilder.DropTable(
                name: "Diaz");

            migrationBuilder.DropTable(
                name: "Celular");
        }
    }
}
