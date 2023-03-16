using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Frutas.Core.Migrations
{
    /// <inheritdoc />
    public partial class adicionandofrutasnobanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Frutas",
                columns: new[] { "Id", "Descricao", "Valor_A", "Valor_B" },
                values: new object[,]
                {
                    { 1, "Banana", 10, 20 },
                    { 2, "Maça", 30, 10 },
                    { 3, "Melancia", 20, 5 },
                    { 4, "Mamão", 11, 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Frutas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Frutas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Frutas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Frutas",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
