using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIMS_dotNet.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Store",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "WarehouseLocation",
                table: "Racks",
                newName: "AssignedWarehouse");

            migrationBuilder.AddColumn<int>(
                name: "AssignedWarehouse",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AssignedSlot",
                table: "Items",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedWarehouse",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AssignedSlot",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "AssignedWarehouse",
                table: "Racks",
                newName: "WarehouseLocation");

            migrationBuilder.AddColumn<string>(
                name: "Store",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
