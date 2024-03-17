using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class addingcascadedeleteonproductcatalogtype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCatalog_ProductCatalogTypes_CatalogTypeId",
                table: "ProductCatalog");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCatalog_ProductCatalogTypes_CatalogTypeId",
                table: "ProductCatalog",
                column: "CatalogTypeId",
                principalTable: "ProductCatalogTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCatalog_ProductCatalogTypes_CatalogTypeId",
                table: "ProductCatalog");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCatalog_ProductCatalogTypes_CatalogTypeId",
                table: "ProductCatalog",
                column: "CatalogTypeId",
                principalTable: "ProductCatalogTypes",
                principalColumn: "Id");
        }
    }
}
