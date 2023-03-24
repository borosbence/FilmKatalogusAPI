using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmKatalogusAPI.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Filmek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cim = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BemutatoDatum = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Mufaj = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmek", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Szineszek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Keresztnev = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Vezeteknev = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nemzetiseg = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SzuletesiDatum = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    OscarNyertes = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Szineszek", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FilmSzinesz",
                columns: table => new
                {
                    FilmekId = table.Column<int>(type: "int", nullable: false),
                    SzineszekId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmSzinesz", x => new { x.FilmekId, x.SzineszekId });
                    table.ForeignKey(
                        name: "FK_FilmSzinesz_Filmek_FilmekId",
                        column: x => x.FilmekId,
                        principalTable: "Filmek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmSzinesz_Szineszek_SzineszekId",
                        column: x => x.SzineszekId,
                        principalTable: "Szineszek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Filmek",
                columns: new[] { "Id", "BemutatoDatum", "Cim", "Mufaj" },
                values: new object[] { 1, new DateTime(1994, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump", "Dráma" });

            migrationBuilder.InsertData(
                table: "Szineszek",
                columns: new[] { "Id", "Keresztnev", "Nemzetiseg", "OscarNyertes", "SzuletesiDatum", "Vezeteknev" },
                values: new object[] { 1, "Tom", "USA", true, new DateTime(1956, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hanks" });

            migrationBuilder.CreateIndex(
                name: "IX_FilmSzinesz_SzineszekId",
                table: "FilmSzinesz",
                column: "SzineszekId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmSzinesz");

            migrationBuilder.DropTable(
                name: "Filmek");

            migrationBuilder.DropTable(
                name: "Szineszek");
        }
    }
}
