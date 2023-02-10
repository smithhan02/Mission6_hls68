using Microsoft.EntityFrameworkCore.Migrations;

namespace newMission6_hls68.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    movieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: true),
                    rating = table.Column<string>(nullable: true),
                    edited = table.Column<bool>(nullable: false),
                    lentTo = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.movieId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Anime", " Hayao Miyazaki", false, "Hannah", "This is a classic!", "G", "Kiki's Delivery Service", 1989 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Anime", " Hayao Miyazaki", false, "Daniel", "Love this movie!", "G", "Ponyo", 2008 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Disney", "AAron Blaise", false, "Ben", "This is my favorite!", "PG", "Brother Bear", 2003 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
