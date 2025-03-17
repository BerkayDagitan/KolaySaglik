using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessKatmani.Migrations
{
    /// <inheritdoc />
    public partial class a4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriListeleri_Uyeler_UyeId",
                table: "FavoriListeleri");

            migrationBuilder.DropForeignKey(
                name: "FK_KaraListelesi_Uyeler_UyeId",
                table: "KaraListelesi");

            migrationBuilder.AlterColumn<int>(
                name: "UyeId",
                table: "KaraListelesi",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UrunId",
                table: "KaraListelesi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UyeId",
                table: "FavoriListeleri",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UrunId",
                table: "FavoriListeleri",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Uyeler",
                keyColumn: "Id",
                keyValue: 2,
                column: "UyelikTarihi",
                value: new DateTime(2025, 3, 11, 22, 59, 21, 55, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.CreateIndex(
                name: "IX_KaraListelesi_UrunId",
                table: "KaraListelesi",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriListeleri_UrunId",
                table: "FavoriListeleri",
                column: "UrunId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriListeleri_Urunler_UrunId",
                table: "FavoriListeleri",
                column: "UrunId",
                principalTable: "Urunler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriListeleri_Uyeler_UyeId",
                table: "FavoriListeleri",
                column: "UyeId",
                principalTable: "Uyeler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KaraListelesi_Urunler_UrunId",
                table: "KaraListelesi",
                column: "UrunId",
                principalTable: "Urunler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KaraListelesi_Uyeler_UyeId",
                table: "KaraListelesi",
                column: "UyeId",
                principalTable: "Uyeler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriListeleri_Urunler_UrunId",
                table: "FavoriListeleri");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriListeleri_Uyeler_UyeId",
                table: "FavoriListeleri");

            migrationBuilder.DropForeignKey(
                name: "FK_KaraListelesi_Urunler_UrunId",
                table: "KaraListelesi");

            migrationBuilder.DropForeignKey(
                name: "FK_KaraListelesi_Uyeler_UyeId",
                table: "KaraListelesi");

            migrationBuilder.DropIndex(
                name: "IX_KaraListelesi_UrunId",
                table: "KaraListelesi");

            migrationBuilder.DropIndex(
                name: "IX_FavoriListeleri_UrunId",
                table: "FavoriListeleri");

            migrationBuilder.DropColumn(
                name: "UrunId",
                table: "KaraListelesi");

            migrationBuilder.DropColumn(
                name: "UrunId",
                table: "FavoriListeleri");

            migrationBuilder.AlterColumn<int>(
                name: "UyeId",
                table: "KaraListelesi",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UyeId",
                table: "FavoriListeleri",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Uyeler",
                keyColumn: "Id",
                keyValue: 2,
                column: "UyelikTarihi",
                value: new DateTime(2025, 3, 11, 22, 36, 34, 883, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriListeleri_Uyeler_UyeId",
                table: "FavoriListeleri",
                column: "UyeId",
                principalTable: "Uyeler",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KaraListelesi_Uyeler_UyeId",
                table: "KaraListelesi",
                column: "UyeId",
                principalTable: "Uyeler",
                principalColumn: "Id");
        }
    }
}
