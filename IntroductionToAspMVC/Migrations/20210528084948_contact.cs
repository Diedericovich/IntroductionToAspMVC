using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IntroductionToAspMVC.Migrations
{
    public partial class contact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Bus = table.Column<int>(type: "int", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Emailadres = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Created", "Genre", "Modified", "Rating", "ReleaseDate", "Title" },
                values: new object[] { 1, new DateTime(2021, 5, 28, 10, 49, 48, 656, DateTimeKind.Local).AddTicks(8202), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7999999999999998, new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jurassic Park" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Created", "Genre", "Modified", "Rating", "ReleaseDate", "Title" },
                values: new object[] { 2, new DateTime(2021, 5, 28, 10, 49, 48, 659, DateTimeKind.Local).AddTicks(2258), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.5, new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terminator 2" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Created", "Genre", "Modified", "Rating", "ReleaseDate", "Title" },
                values: new object[] { 3, new DateTime(2021, 5, 28, 10, 49, 48, 659, DateTimeKind.Local).AddTicks(2293), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7999999999999998, new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Thing" });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AddressId",
                table: "Contacts",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
