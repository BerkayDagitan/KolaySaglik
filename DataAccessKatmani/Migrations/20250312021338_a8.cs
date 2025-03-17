using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessKatmani.Migrations
{
    /// <inheritdoc />
    public partial class a8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Uyeler",
                keyColumn: "Id",
                keyValue: 2,
                column: "UyelikTarihi",
                value: new DateTime(2025, 3, 12, 5, 13, 37, 804, DateTimeKind.Local).AddTicks(1183));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Uyeler",
                keyColumn: "Id",
                keyValue: 2,
                column: "UyelikTarihi",
                value: new DateTime(2025, 3, 12, 0, 1, 46, 30, DateTimeKind.Local).AddTicks(1399));
        }
    }
}
