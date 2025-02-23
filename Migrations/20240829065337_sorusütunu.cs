using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GülsanAraçKayıt.Migrations
{
    /// <inheritdoc />
    public partial class sorusütunu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "sorular",
                table: "VehicleRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sorular",
                table: "VehicleRecords");
        }
    }
}
