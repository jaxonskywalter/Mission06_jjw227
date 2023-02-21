using Microsoft.EntityFrameworkCore.Migrations;

namespace DateMe.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "SubmissionId",
                keyValue: 2,
                column: "CategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "SubmissionId",
                keyValue: 3,
                column: "CategoryId",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "SubmissionId",
                keyValue: 2,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "SubmissionId",
                keyValue: 3,
                column: "CategoryId",
                value: 3);
        }
    }
}
