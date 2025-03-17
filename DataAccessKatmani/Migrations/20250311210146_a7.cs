using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessKatmani.Migrations
{
    /// <inheritdoc />
    public partial class a7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrunIcerik",
                table: "Urunler");

            migrationBuilder.UpdateData(
                table: "Uyeler",
                keyColumn: "Id",
                keyValue: 2,
                column: "UyelikTarihi",
                value: new DateTime(2025, 3, 12, 0, 1, 46, 30, DateTimeKind.Local).AddTicks(1399));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UrunIcerik",
                table: "Urunler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Uyeler",
                keyColumn: "Id",
                keyValue: 2,
                column: "UyelikTarihi",
                value: new DateTime(2025, 3, 11, 23, 45, 58, 127, DateTimeKind.Local).AddTicks(6187));
        }
    }
}
