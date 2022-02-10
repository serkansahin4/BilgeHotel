using Microsoft.EntityFrameworkCore.Migrations;

namespace BilgeHotel.WebUI.Migrations
{
    public partial class yenige : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "RoomBeds",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "RoomBeds");
        }
    }
}
