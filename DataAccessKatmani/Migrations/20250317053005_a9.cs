using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessKatmani.Migrations
{
    /// <inheritdoc />
    public partial class a9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urunler_Kategoriler_KategoriId",
                table: "Urunler");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropIndex(
                name: "IX_Urunler_KategoriId",
                table: "Urunler");

            migrationBuilder.DeleteData(
                table: "Uyeler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "KategoriId",
                table: "Urunler",
                newName: "Kategori");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Kategori",
                table: "Urunler",
                newName: "KategoriId");

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kategoriler = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Uyeler",
                columns: new[] { "Id", "Ad", "KullaniciAdi", "MailAdresi", "Rol", "Sifre", "Soyad", "UyelikTarihi" },
                values: new object[] { 2, "Admin", "admin123", "kolaysaglik.admin@gmail.com", 1, "Admin12345", "User", new DateTime(2025, 3, 12, 5, 13, 37, 804, DateTimeKind.Local).AddTicks(1183) });

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_KategoriId",
                table: "Urunler",
                column: "KategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Urunler_Kategoriler_KategoriId",
                table: "Urunler",
                column: "KategoriId",
                principalTable: "Kategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
