using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bacchanalia_Sales.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Course = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MondaySales = table.Column<int>(type: "int", nullable: false),
                    TuesdaySales = table.Column<int>(type: "int", nullable: false),
                    WednesdaySales = table.Column<int>(type: "int", nullable: false),
                    ThursdaySales = table.Column<int>(type: "int", nullable: false),
                    FridaySales = table.Column<int>(type: "int", nullable: false),
                    SaturdaySales = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
