using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoHostingMNO.Migrations
{
    public partial class addedBonnetjes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bonnetjes",
                table: "Pakjes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bonnetjes",
                table: "Pakjes");
        }
    }
}
