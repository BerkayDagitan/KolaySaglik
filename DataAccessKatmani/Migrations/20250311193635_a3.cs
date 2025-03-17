using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessKatmani.Migrations
{
    /// <inheritdoc />
    public partial class a3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rol",
                table: "Uyeler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Uyeler",
                columns: new[] { "Id", "Ad", "KullaniciAdi", "MailAdresi", "Rol", "Sifre", "Soyad", "UyelikTarihi" },
                values: new object[] { 2, "Admin", "admin123", "kolaysaglik.admin@gmail.com", 1, "Admin12345", "User", new DateTime(2025, 3, 11, 22, 36, 34, 883, DateTimeKind.Local).AddTicks(5599) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Uyeler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Rol",
                table: "Uyeler");
        }
    }
}
