using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KeepNoteAPI.Data.Migrations
{
    public partial class Iki : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[,]
                {
                    { 1, "This is the content of the first note.", "First Note" },
                    { 2, "This is the content of the second note.", "Second Note" },
                    { 3, null, "Third Note" },
                    { 4, "This is the content of the fourth note.", "Fourth Note" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
