using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bacchanalia_Sales.Migrations
{
    /// <inheritdoc />
    public partial class Week : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Week",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Week",
                table: "Products");
        }
    }
}
