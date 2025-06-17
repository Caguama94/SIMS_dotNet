using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIMS_dotNet.Migrations
{
    /// <inheritdoc />
    public partial class AddedItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemFormat = table.Column<double>(type: "float", nullable: true),
                    ItemAppearance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemSurfaceFinish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemDateOfFabrication = table.Column<int>(type: "int", nullable: true),
                    ItemBatch = table.Column<int>(type: "int", nullable: true),
                    ItemBoxLenght = table.Column<double>(type: "float", nullable: true),
                    ItemBoxWidth = table.Column<double>(type: "float", nullable: true),
                    ItemBoxHeight = table.Column<double>(type: "float", nullable: true),
                    ItemBoxWeight = table.Column<double>(type: "float", nullable: true),
                    ItemPerBox = table.Column<int>(type: "int", nullable: true),
                    ItemSurfacePerBox = table.Column<double>(type: "float", nullable: true),
                    ItemCost = table.Column<double>(type: "float", nullable: true),
                    ItemStock = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
