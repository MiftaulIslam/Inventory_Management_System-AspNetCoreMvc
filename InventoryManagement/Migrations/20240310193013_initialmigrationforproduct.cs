using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class initialmigrationforproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductCatalog_ProductCatalogId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStock_Product_ProductId",
                table: "ProductStock");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseList_Product_ProductId",
                table: "PurchaseList");

            migrationBuilder.DropForeignKey(
                name: "FK_SellingAdjustment_Product_ProductId",
                table: "SellingAdjustment");

            migrationBuilder.DropForeignKey(
                name: "FK_SellingList_Product_ProductId",
                table: "SellingList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ProductCatalogId",
                table: "Products",
                newName: "IX_Products_ProductCatalogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCatalog_ProductCatalogId",
                table: "Products",
                column: "ProductCatalogId",
                principalTable: "ProductCatalog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStock_Products_ProductId",
                table: "ProductStock",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseList_Products_ProductId",
                table: "PurchaseList",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SellingAdjustment_Products_ProductId",
                table: "SellingAdjustment",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SellingList_Products_ProductId",
                table: "SellingList",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCatalog_ProductCatalogId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStock_Products_ProductId",
                table: "ProductStock");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseList_Products_ProductId",
                table: "PurchaseList");

            migrationBuilder.DropForeignKey(
                name: "FK_SellingAdjustment_Products_ProductId",
                table: "SellingAdjustment");

            migrationBuilder.DropForeignKey(
                name: "FK_SellingList_Products_ProductId",
                table: "SellingList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductCatalogId",
                table: "Product",
                newName: "IX_Product_ProductCatalogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductCatalog_ProductCatalogId",
                table: "Product",
                column: "ProductCatalogId",
                principalTable: "ProductCatalog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStock_Product_ProductId",
                table: "ProductStock",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseList_Product_ProductId",
                table: "PurchaseList",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SellingAdjustment_Product_ProductId",
                table: "SellingAdjustment",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SellingList_Product_ProductId",
                table: "SellingList",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
