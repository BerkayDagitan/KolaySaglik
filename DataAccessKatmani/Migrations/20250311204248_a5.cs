using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessKatmani.Migrations
{
    /// <inheritdoc />
    public partial class a5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urunler_Ureticiler_UreticiId",
                table: "Urunler");

            migrationBuilder.DropTable(
                name: "Ureticiler");

            migrationBuilder.DropTable(
                name: "UrunIcerikleri");

            migrationBuilder.DropIndex(
                name: "IX_Urunler_UreticiId",
                table: "Urunler");

            migrationBuilder.RenameColumn(
                name: "UreticiId",
                table: "Urunler",
                newName: "UrunIcerik");

            migrationBuilder.AddColumn<int>(
                name: "Uretici",
                table: "Urunler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UrunIcerikler",
                table: "Urunler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Uyeler",
                keyColumn: "Id",
                keyValue: 2,
                column: "UyelikTarihi",
                value: new DateTime(2025, 3, 11, 23, 42, 48, 268, DateTimeKind.Local).AddTicks(2308));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Uretici",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "UrunIcerikler",
                table: "Urunler");

            migrationBuilder.RenameColumn(
                name: "UrunIcerik",
                table: "Urunler",
                newName: "UreticiId");

            migrationBuilder.CreateTable(
                name: "Ureticiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ureticiler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UrunIcerikleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunId = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunIcerikleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UrunIcerikleri_Urunler_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Uyeler",
                keyColumn: "Id",
                keyValue: 2,
                column: "UyelikTarihi",
                value: new DateTime(2025, 3, 11, 22, 59, 21, 55, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_UreticiId",
                table: "Urunler",
                column: "UreticiId");

            migrationBuilder.CreateIndex(
                name: "IX_UrunIcerikleri_UrunId",
                table: "UrunIcerikleri",
                column: "UrunId");

            migrationBuilder.AddForeignKey(
                name: "FK_Urunler_Ureticiler_UreticiId",
                table: "Urunler",
                column: "UreticiId",
                principalTable: "Ureticiler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
