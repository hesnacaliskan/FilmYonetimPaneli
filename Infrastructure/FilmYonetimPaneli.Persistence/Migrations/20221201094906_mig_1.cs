using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmYonetimPaneli.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    filmID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    filmAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    filmYapimYil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.filmID);
                });

            migrationBuilder.CreateTable(
                name: "Salons",
                columns: table => new
                {
                    salonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    salonAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salons", x => x.salonID);
                });

            migrationBuilder.CreateTable(
                name: "FilmSalon",
                columns: table => new
                {
                    FilmsfilmID = table.Column<int>(type: "int", nullable: false),
                    SalonssalonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmSalon", x => new { x.FilmsfilmID, x.SalonssalonID });
                    table.ForeignKey(
                        name: "FK_FilmSalon_Films_FilmsfilmID",
                        column: x => x.FilmsfilmID,
                        principalTable: "Films",
                        principalColumn: "filmID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmSalon_Salons_SalonssalonID",
                        column: x => x.SalonssalonID,
                        principalTable: "Salons",
                        principalColumn: "salonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmSalon_SalonssalonID",
                table: "FilmSalon",
                column: "SalonssalonID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmSalon");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Salons");
        }
    }
}
