using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VmtCounties",
                columns: table => new
                {
                    CountyFips = table.Column<int>(type: "INTEGER", nullable: false),
                    CountyName = table.Column<string>(type: "TEXT", nullable: true),
                    StateName = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<string>(type: "TEXT", nullable: true),
                    CountyVmt = table.Column<long>(type: "INTEGER", nullable: false),
                    BaselineJanVmt = table.Column<long>(type: "INTEGER", nullable: false),
                    PercentChangeFromJan = table.Column<double>(type: "REAL", nullable: false),
                    Mean7CountyVmt = table.Column<double>(type: "REAL", nullable: false),
                    Mean7PercentChangeFromJan = table.Column<double>(type: "REAL", nullable: false),
                    DateAtLow = table.Column<string>(type: "TEXT", nullable: true),
                    Mean7CountyVmtAtLow = table.Column<double>(type: "REAL", nullable: false),
                    PercentChangeFromLow = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VmtCounties");
        }
    }
}
