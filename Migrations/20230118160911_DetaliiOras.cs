using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ungureanu_Gabriel_Sebastian_CIG7.Migrations
{
    public partial class DetaliiOras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "OraDeschidere",
                table: "Oras",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "OraInchidere",
                table: "Oras",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Strada",
                table: "Oras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OraDeschidere",
                table: "Oras");

            migrationBuilder.DropColumn(
                name: "OraInchidere",
                table: "Oras");

            migrationBuilder.DropColumn(
                name: "Strada",
                table: "Oras");
        }
    }
}
