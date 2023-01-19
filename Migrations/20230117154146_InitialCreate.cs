using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ungureanu_Gabriel_Sebastian_CIG7.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bilet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Plecare = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destinatie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pret = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bilet", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bilet");
        }
    }
}
