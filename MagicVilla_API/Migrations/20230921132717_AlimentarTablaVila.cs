using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVila : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalles de la villa", new DateTime(2023, 9, 21, 7, 27, 17, 263, DateTimeKind.Local).AddTicks(9180), new DateTime(2023, 9, 21, 7, 27, 17, 263, DateTimeKind.Local).AddTicks(9166), "", 50, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalles de la villa...", new DateTime(2023, 9, 21, 7, 27, 17, 263, DateTimeKind.Local).AddTicks(9184), new DateTime(2023, 9, 21, 7, 27, 17, 263, DateTimeKind.Local).AddTicks(9183), "", 150, "Villa No Real", 10, 500.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
