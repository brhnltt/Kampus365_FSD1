using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_RentACarOrnegi.Migrations
{
    public partial class LimitKMAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LimitKM",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LimitKM",
                table: "Rentings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LimitKM",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "LimitKM",
                table: "Rentings");
        }
    }
}
