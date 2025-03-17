using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessKatmani.Migrations
{
    /// <inheritdoc />
    public partial class a6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrunIcerigi",
                table: "KaraListelesi",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UrunIcerigi",
                table: "FavoriListeleri",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Uyeler",
                keyColumn: "Id",
                keyValue: 2,
                column: "UyelikTarihi",
                value: new DateTime(2025, 3, 11, 23, 45, 58, 127, DateTimeKind.Local).AddTicks(6187));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrunIcerigi",
                table: "KaraListelesi");

            migrationBuilder.DropColumn(
                name: "UrunIcerigi",
                table: "FavoriListeleri");

            migrationBuilder.UpdateData(
                table: "Uyeler",
                keyColumn: "Id",
                keyValue: 2,
                column: "UyelikTarihi",
                value: new DateTime(2025, 3, 11, 23, 42, 48, 268, DateTimeKind.Local).AddTicks(2308));
        }
    }
}
