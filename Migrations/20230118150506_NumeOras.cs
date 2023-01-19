using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ungureanu_Gabriel_Sebastian_CIG7.Migrations
{
    public partial class NumeOras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Plecare",
                table: "Bilet");

            migrationBuilder.AddColumn<int>(
                name: "OrasID",
                table: "Bilet",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Oras",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrasGara = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oras", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bilet_OrasID",
                table: "Bilet",
                column: "OrasID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bilet_Oras_OrasID",
                table: "Bilet",
                column: "OrasID",
                principalTable: "Oras",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bilet_Oras_OrasID",
                table: "Bilet");

            migrationBuilder.DropTable(
                name: "Oras");

            migrationBuilder.DropIndex(
                name: "IX_Bilet_OrasID",
                table: "Bilet");

            migrationBuilder.DropColumn(
                name: "OrasID",
                table: "Bilet");

            migrationBuilder.AddColumn<string>(
                name: "Plecare",
                table: "Bilet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
