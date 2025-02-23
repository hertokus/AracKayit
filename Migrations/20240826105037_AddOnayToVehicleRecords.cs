using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GülsanAraçKayıt.Migrations
{
    /// <inheritdoc />
    public partial class AddOnayToVehicleRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Onay",
                table: "VehicleRecords",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Onay",
                table: "VehicleRecords");
        }
    }
}
