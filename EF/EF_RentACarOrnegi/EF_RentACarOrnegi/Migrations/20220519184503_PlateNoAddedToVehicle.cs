using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_RentACarOrnegi.Migrations
{
    public partial class PlateNoAddedToVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PlateNo",
                table: "Vehicles",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlateNo",
                table: "Vehicles");
        }
    }
}
