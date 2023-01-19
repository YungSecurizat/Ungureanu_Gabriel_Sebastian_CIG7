using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ungureanu_Gabriel_Sebastian_CIG7.Migrations
{
    public partial class CompanieMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanieID",
                table: "Bilet",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Companie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanieN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anulinfiintari = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companie", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bilet_CompanieID",
                table: "Bilet",
                column: "CompanieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bilet_Companie_CompanieID",
                table: "Bilet",
                column: "CompanieID",
                principalTable: "Companie",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bilet_Companie_CompanieID",
                table: "Bilet");

            migrationBuilder.DropTable(
                name: "Companie");

            migrationBuilder.DropIndex(
                name: "IX_Bilet_CompanieID",
                table: "Bilet");

            migrationBuilder.DropColumn(
                name: "CompanieID",
                table: "Bilet");
        }
    }
}
