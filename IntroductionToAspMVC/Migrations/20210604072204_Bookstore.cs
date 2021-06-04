using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IntroductionToAspMVC.Migrations
{
    public partial class Bookstore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 6, 4, 9, 22, 4, 59, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 6, 4, 9, 22, 4, 61, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 6, 4, 9, 22, 4, 61, DateTimeKind.Local).AddTicks(8978));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 5, 28, 13, 12, 53, 358, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 5, 28, 13, 12, 53, 360, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 5, 28, 13, 12, 53, 360, DateTimeKind.Local).AddTicks(8733));
        }
    }
}
