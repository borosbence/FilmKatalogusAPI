using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmKatalogusAPI.Migrations
{
    public partial class filmmufaj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mufaj",
                table: "Filmek");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BemutatoDatum",
                table: "Filmek",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddColumn<int>(
                name: "FilmMufajId",
                table: "Filmek",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FilmMufajok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nev = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Korhatar = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmMufajok", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Filmek_FilmMufajId",
                table: "Filmek",
                column: "FilmMufajId");

            migrationBuilder.AddForeignKey(
                name: "FK_Filmek_FilmMufajok_FilmMufajId",
                table: "Filmek",
                column: "FilmMufajId",
                principalTable: "FilmMufajok",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filmek_FilmMufajok_FilmMufajId",
                table: "Filmek");

            migrationBuilder.DropTable(
                name: "FilmMufajok");

            migrationBuilder.DropIndex(
                name: "IX_Filmek_FilmMufajId",
                table: "Filmek");

            migrationBuilder.DropColumn(
                name: "FilmMufajId",
                table: "Filmek");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BemutatoDatum",
                table: "Filmek",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mufaj",
                table: "Filmek",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
