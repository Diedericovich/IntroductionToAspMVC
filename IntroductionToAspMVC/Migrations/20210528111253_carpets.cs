using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IntroductionToAspMVC.Migrations
{
    public partial class carpets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carpet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Texture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeSquared = table.Column<double>(type: "float", nullable: false),
                    IsHypoAllergic = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carpet", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carpet");

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
    }
}
