using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIMS_dotNet.Migrations
{
    /// <inheritdoc />
    public partial class RenamingTableItemFromItemsToItemAndAddedDatetimeToDateOfFabrication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Format = table.Column<double>(type: "float", nullable: true),
                    Appearance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurfaceFinish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfFabrication = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Batch = table.Column<int>(type: "int", nullable: true),
                    BoxLenght = table.Column<double>(type: "float", nullable: true),
                    BoxWidth = table.Column<double>(type: "float", nullable: true),
                    BoxHeight = table.Column<double>(type: "float", nullable: true),
                    BoxWeight = table.Column<double>(type: "float", nullable: true),
                    QtyPerBox = table.Column<int>(type: "int", nullable: true),
                    SurfacePerBox = table.Column<double>(type: "float", nullable: true),
                    Cost = table.Column<double>(type: "float", nullable: true),
                    Stock = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Appearance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batch = table.Column<int>(type: "int", nullable: true),
                    BoxHeight = table.Column<double>(type: "float", nullable: true),
                    BoxLenght = table.Column<double>(type: "float", nullable: true),
                    BoxWeight = table.Column<double>(type: "float", nullable: true),
                    BoxWidth = table.Column<double>(type: "float", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<double>(type: "float", nullable: true),
                    DateOfFabrication = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Format = table.Column<double>(type: "float", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtyPerBox = table.Column<int>(type: "int", nullable: true),
                    Stock = table.Column<double>(type: "float", nullable: true),
                    SurfaceFinish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurfacePerBox = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });
        }
    }
}
