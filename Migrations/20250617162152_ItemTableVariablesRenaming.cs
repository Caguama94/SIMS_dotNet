using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIMS_dotNet.Migrations
{
    /// <inheritdoc />
    public partial class ItemTableVariablesRenaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemSurfacePerBox",
                table: "Items",
                newName: "SurfacePerBox");

            migrationBuilder.RenameColumn(
                name: "ItemSurfaceFinish",
                table: "Items",
                newName: "SurfaceFinish");

            migrationBuilder.RenameColumn(
                name: "ItemStock",
                table: "Items",
                newName: "Stock");

            migrationBuilder.RenameColumn(
                name: "ItemPerBox",
                table: "Items",
                newName: "QtyPerBox");

            migrationBuilder.RenameColumn(
                name: "ItemName",
                table: "Items",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ItemMaterial",
                table: "Items",
                newName: "Material");

            migrationBuilder.RenameColumn(
                name: "ItemFormat",
                table: "Items",
                newName: "Format");

            migrationBuilder.RenameColumn(
                name: "ItemDescription",
                table: "Items",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ItemDateOfFabrication",
                table: "Items",
                newName: "DateOfFabrication");

            migrationBuilder.RenameColumn(
                name: "ItemCost",
                table: "Items",
                newName: "Cost");

            migrationBuilder.RenameColumn(
                name: "ItemColor",
                table: "Items",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "ItemBoxWidth",
                table: "Items",
                newName: "BoxWidth");

            migrationBuilder.RenameColumn(
                name: "ItemBoxWeight",
                table: "Items",
                newName: "BoxWeight");

            migrationBuilder.RenameColumn(
                name: "ItemBoxLenght",
                table: "Items",
                newName: "BoxLenght");

            migrationBuilder.RenameColumn(
                name: "ItemBoxHeight",
                table: "Items",
                newName: "BoxHeight");

            migrationBuilder.RenameColumn(
                name: "ItemBatch",
                table: "Items",
                newName: "Batch");

            migrationBuilder.RenameColumn(
                name: "ItemAppearance",
                table: "Items",
                newName: "Appearance");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Items",
                newName: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SurfacePerBox",
                table: "Items",
                newName: "ItemSurfacePerBox");

            migrationBuilder.RenameColumn(
                name: "SurfaceFinish",
                table: "Items",
                newName: "ItemSurfaceFinish");

            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Items",
                newName: "ItemStock");

            migrationBuilder.RenameColumn(
                name: "QtyPerBox",
                table: "Items",
                newName: "ItemPerBox");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Items",
                newName: "ItemName");

            migrationBuilder.RenameColumn(
                name: "Material",
                table: "Items",
                newName: "ItemMaterial");

            migrationBuilder.RenameColumn(
                name: "Format",
                table: "Items",
                newName: "ItemFormat");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Items",
                newName: "ItemDescription");

            migrationBuilder.RenameColumn(
                name: "DateOfFabrication",
                table: "Items",
                newName: "ItemDateOfFabrication");

            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "Items",
                newName: "ItemCost");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Items",
                newName: "ItemColor");

            migrationBuilder.RenameColumn(
                name: "BoxWidth",
                table: "Items",
                newName: "ItemBoxWidth");

            migrationBuilder.RenameColumn(
                name: "BoxWeight",
                table: "Items",
                newName: "ItemBoxWeight");

            migrationBuilder.RenameColumn(
                name: "BoxLenght",
                table: "Items",
                newName: "ItemBoxLenght");

            migrationBuilder.RenameColumn(
                name: "BoxHeight",
                table: "Items",
                newName: "ItemBoxHeight");

            migrationBuilder.RenameColumn(
                name: "Batch",
                table: "Items",
                newName: "ItemBatch");

            migrationBuilder.RenameColumn(
                name: "Appearance",
                table: "Items",
                newName: "ItemAppearance");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Items",
                newName: "ItemId");
        }
    }
}
