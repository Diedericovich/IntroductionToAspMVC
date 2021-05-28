using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IntroductionToAspMVC.Migrations
{
    public partial class dateofbirth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 5, 28, 11, 21, 17, 368, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 5, 28, 11, 21, 17, 370, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 5, 28, 11, 21, 17, 370, DateTimeKind.Local).AddTicks(553));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Contacts");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 5, 28, 10, 49, 48, 656, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 5, 28, 10, 49, 48, 659, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 5, 28, 10, 49, 48, 659, DateTimeKind.Local).AddTicks(2293));
        }
    }
}
