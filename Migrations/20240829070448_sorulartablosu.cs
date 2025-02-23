using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GülsanAraçKayıt.Migrations
{
    /// <inheritdoc />
    public partial class sorulartablosu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sorular",
                table: "VehicleRecords");

            migrationBuilder.CreateTable(
                name: "FormSorular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormSorular = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormSorular", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormSorular");

            migrationBuilder.AddColumn<string>(
                name: "sorular",
                table: "VehicleRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
