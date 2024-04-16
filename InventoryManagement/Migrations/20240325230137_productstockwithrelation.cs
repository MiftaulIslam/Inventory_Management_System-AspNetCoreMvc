using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class productstockwithrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDamaged_ProductStock_ProductStockId",
                table: "ProductDamaged");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLog_ProductStock_ProductStockId",
                table: "ProductLog");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStock_Products_ProductId",
                table: "ProductStock");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStock_PurchaseList_PurchaseListId",
                table: "ProductStock");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStock_SellingList_SellingListId",
                table: "ProductStock");

            migrationBuilder.DropForeignKey(
                name: "FK_SellingAdjustment_ProductStock_ProductStockId",
                table: "SellingAdjustment");

            migrationBuilder.DropForeignKey(
                name: "FK_Warranty_ProductStock_ProductStockId",
                table: "Warranty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductStock",
                table: "ProductStock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductDamaged",
                table: "ProductDamaged");

            migrationBuilder.RenameTable(
                name: "ProductStock",
                newName: "ProductStocks");

            migrationBuilder.RenameTable(
                name: "ProductDamaged",
                newName: "ProductDamageds");

            migrationBuilder.RenameIndex(
                name: "IX_ProductStock_SellingListId",
                table: "ProductStocks",
                newName: "IX_ProductStocks_SellingListId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductStock_PurchaseListId",
                table: "ProductStocks",
                newName: "IX_ProductStocks_PurchaseListId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductStock_ProductId",
                table: "ProductStocks",
                newName: "IX_ProductStocks_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductDamaged_ProductStockId",
                table: "ProductDamageds",
                newName: "IX_ProductDamageds_ProductStockId");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "ProductStocks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDamage",
                table: "ProductStocks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductStocks",
                table: "ProductStocks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductDamageds",
                table: "ProductDamageds",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDamageds_ProductStocks_ProductStockId",
                table: "ProductDamageds",
                column: "ProductStockId",
                principalTable: "ProductStocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLog_ProductStocks_ProductStockId",
                table: "ProductLog",
                column: "ProductStockId",
                principalTable: "ProductStocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStocks_Products_ProductId",
                table: "ProductStocks",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStocks_PurchaseList_PurchaseListId",
                table: "ProductStocks",
                column: "PurchaseListId",
                principalTable: "PurchaseList",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStocks_SellingList_SellingListId",
                table: "ProductStocks",
                column: "SellingListId",
                principalTable: "SellingList",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SellingAdjustment_ProductStocks_ProductStockId",
                table: "SellingAdjustment",
                column: "ProductStockId",
                principalTable: "ProductStocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Warranty_ProductStocks_ProductStockId",
                table: "Warranty",
                column: "ProductStockId",
                principalTable: "ProductStocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDamageds_ProductStocks_ProductStockId",
                table: "ProductDamageds");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLog_ProductStocks_ProductStockId",
                table: "ProductLog");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStocks_Products_ProductId",
                table: "ProductStocks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStocks_PurchaseList_PurchaseListId",
                table: "ProductStocks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStocks_SellingList_SellingListId",
                table: "ProductStocks");

            migrationBuilder.DropForeignKey(
                name: "FK_SellingAdjustment_ProductStocks_ProductStockId",
                table: "SellingAdjustment");

            migrationBuilder.DropForeignKey(
                name: "FK_Warranty_ProductStocks_ProductStockId",
                table: "Warranty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductStocks",
                table: "ProductStocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductDamageds",
                table: "ProductDamageds");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "ProductStocks");

            migrationBuilder.DropColumn(
                name: "IsDamage",
                table: "ProductStocks");

            migrationBuilder.RenameTable(
                name: "ProductStocks",
                newName: "ProductStock");

            migrationBuilder.RenameTable(
                name: "ProductDamageds",
                newName: "ProductDamaged");

            migrationBuilder.RenameIndex(
                name: "IX_ProductStocks_SellingListId",
                table: "ProductStock",
                newName: "IX_ProductStock_SellingListId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductStocks_PurchaseListId",
                table: "ProductStock",
                newName: "IX_ProductStock_PurchaseListId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductStocks_ProductId",
                table: "ProductStock",
                newName: "IX_ProductStock_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductDamageds_ProductStockId",
                table: "ProductDamaged",
                newName: "IX_ProductDamaged_ProductStockId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductStock",
                table: "ProductStock",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductDamaged",
                table: "ProductDamaged",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDamaged_ProductStock_ProductStockId",
                table: "ProductDamaged",
                column: "ProductStockId",
                principalTable: "ProductStock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLog_ProductStock_ProductStockId",
                table: "ProductLog",
                column: "ProductStockId",
                principalTable: "ProductStock",
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
                name: "FK_ProductStock_PurchaseList_PurchaseListId",
                table: "ProductStock",
                column: "PurchaseListId",
                principalTable: "PurchaseList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStock_SellingList_SellingListId",
                table: "ProductStock",
                column: "SellingListId",
                principalTable: "SellingList",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SellingAdjustment_ProductStock_ProductStockId",
                table: "SellingAdjustment",
                column: "ProductStockId",
                principalTable: "ProductStock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Warranty_ProductStock_ProductStockId",
                table: "Warranty",
                column: "ProductStockId",
                principalTable: "ProductStock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
