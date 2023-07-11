using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bacchanalia_Sales.Migrations
{
    /// <inheritdoc />
    public partial class Id : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("0000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Products");
        }
    }
}
