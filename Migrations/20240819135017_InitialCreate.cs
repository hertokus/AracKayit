using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GülsanAraçKayıt.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehicleRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Plaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DorsePlakasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoforAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuvenlikAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NakliyeSirketi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsletmedenGeldigiYer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleRecords", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleRecords");
        }
    }
}
