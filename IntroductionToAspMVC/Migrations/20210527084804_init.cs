using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IntroductionToAspMVC.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Created", "Genre", "Modified", "Rating", "ReleaseDate", "Title" },
                values: new object[] { 1, new DateTime(2021, 5, 27, 10, 48, 4, 206, DateTimeKind.Local).AddTicks(4935), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7999999999999998, new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jurassic Park" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Created", "Genre", "Modified", "Rating", "ReleaseDate", "Title" },
                values: new object[] { 2, new DateTime(2021, 5, 27, 10, 48, 4, 208, DateTimeKind.Local).AddTicks(3918), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.5, new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terminator 2" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Created", "Genre", "Modified", "Rating", "ReleaseDate", "Title" },
                values: new object[] { 3, new DateTime(2021, 5, 27, 10, 48, 4, 208, DateTimeKind.Local).AddTicks(3944), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7999999999999998, new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Thing" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
