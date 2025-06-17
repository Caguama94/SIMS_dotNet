using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIMS_dotNet.Migrations
{
    /// <inheritdoc />
    public partial class AddedStockToSlotsAndRacks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Slots",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductStock",
                table: "Slots",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmptySlots",
                table: "Racks",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Slots");

            migrationBuilder.DropColumn(
                name: "ProductStock",
                table: "Slots");

            migrationBuilder.DropColumn(
                name: "EmptySlots",
                table: "Racks");
        }
    }
}
