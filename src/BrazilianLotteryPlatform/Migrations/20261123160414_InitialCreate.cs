using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrazilianLotteryPlatform.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LotteryConfigs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    MinNumbersPerGame = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxNumbersPerGame = table.Column<int>(type: "INTEGER", nullable: false),
                    MinValue = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxValue = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotteryConfigs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "LotteryConfigs",
                columns: new[] { "Id", "MaxNumbersPerGame", "MaxValue", "MinNumbersPerGame", "MinValue", "Name" },
                values: new object[] { "MegaSena", 20, 60, 6, 1, "Mega-Sena" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LotteryConfigs");
        }
    }
}
