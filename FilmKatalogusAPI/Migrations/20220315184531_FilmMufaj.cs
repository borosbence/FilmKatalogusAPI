using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmKatalogusAPI.Migrations
{
    public partial class FilmMufaj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "FilmMufajok",
                columns: new[] { "Id", "Korhatar", "Nev" },
                values: new object[] { 1, 12, "Dráma" });

            migrationBuilder.UpdateData(
                table: "Filmek",
                keyColumn: "Id",
                keyValue: 1,
                column: "FilmMufajId",
                value: 1);

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
        }
    }
}
