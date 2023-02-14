using Microsoft.EntityFrameworkCore.Migrations;

namespace DateMe.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    SubmissionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.SubmissionId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "SubmissionId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action", "Christofer Nolan", false, "", "Favorite movie ever!", "PG-13", "Inception", 2010 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "SubmissionId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Horror", "Mark Mylod", false, "", "Best movie recently.", "R", "The Menu", 2022 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "SubmissionId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "SciFi", "Gareth Edwards", true, "", "Best Star Wars movie.", "PG-13", "Rogue One", 2016 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
