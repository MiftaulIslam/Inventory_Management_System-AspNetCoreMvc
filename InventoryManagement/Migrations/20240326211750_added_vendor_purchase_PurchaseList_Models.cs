using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class added_vendor_purchase_PurchaseList_Models : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductLog_Purchase_PurchaseId",
                table: "ProductLog");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStocks_PurchaseList_PurchaseListId",
                table: "ProductStocks");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Registration_RegistrationId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Vendor_VendorId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseList_Products_ProductId",
                table: "PurchaseList");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseList_Purchase_PurchaseId",
                table: "PurchaseList");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasePayment_Vendor_VendorId",
                table: "PurchasePayment");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasePaymentList_Purchase_PurchaseId",
                table: "PurchasePaymentList");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasePaymentReturnRecord_Purchase_PurchaseId",
                table: "PurchasePaymentReturnRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_Selling_Purchase_PurchaseId",
                table: "Selling");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendor",
                table: "Vendor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseList",
                table: "PurchaseList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Purchase",
                table: "Purchase");

            migrationBuilder.RenameTable(
                name: "Vendor",
                newName: "Vendors");

            migrationBuilder.RenameTable(
                name: "PurchaseList",
                newName: "PurchaseLists");

            migrationBuilder.RenameTable(
                name: "Purchase",
                newName: "Purchases");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseList_PurchaseId",
                table: "PurchaseLists",
                newName: "IX_PurchaseLists_PurchaseId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseList_ProductId",
                table: "PurchaseLists",
                newName: "IX_PurchaseLists_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Purchase_VendorId",
                table: "Purchases",
                newName: "IX_Purchases_VendorId");

            migrationBuilder.RenameIndex(
                name: "IX_Purchase_RegistrationId",
                table: "Purchases",
                newName: "IX_Purchases_RegistrationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendors",
                table: "Vendors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseLists",
                table: "PurchaseLists",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Purchases",
                table: "Purchases",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLog_Purchases_PurchaseId",
                table: "ProductLog",
                column: "PurchaseId",
                principalTable: "Purchases",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStocks_PurchaseLists_PurchaseListId",
                table: "ProductStocks",
                column: "PurchaseListId",
                principalTable: "PurchaseLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseLists_Products_ProductId",
                table: "PurchaseLists",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseLists_Purchases_PurchaseId",
                table: "PurchaseLists",
                column: "PurchaseId",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasePayment_Vendors_VendorId",
                table: "PurchasePayment",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasePaymentList_Purchases_PurchaseId",
                table: "PurchasePaymentList",
                column: "PurchaseId",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasePaymentReturnRecord_Purchases_PurchaseId",
                table: "PurchasePaymentReturnRecord",
                column: "PurchaseId",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Registration_RegistrationId",
                table: "Purchases",
                column: "RegistrationId",
                principalTable: "Registration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Vendors_VendorId",
                table: "Purchases",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Selling_Purchases_PurchaseId",
                table: "Selling",
                column: "PurchaseId",
                principalTable: "Purchases",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductLog_Purchases_PurchaseId",
                table: "ProductLog");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStocks_PurchaseLists_PurchaseListId",
                table: "ProductStocks");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseLists_Products_ProductId",
                table: "PurchaseLists");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseLists_Purchases_PurchaseId",
                table: "PurchaseLists");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasePayment_Vendors_VendorId",
                table: "PurchasePayment");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasePaymentList_Purchases_PurchaseId",
                table: "PurchasePaymentList");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasePaymentReturnRecord_Purchases_PurchaseId",
                table: "PurchasePaymentReturnRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Registration_RegistrationId",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Vendors_VendorId",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Selling_Purchases_PurchaseId",
                table: "Selling");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendors",
                table: "Vendors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Purchases",
                table: "Purchases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseLists",
                table: "PurchaseLists");

            migrationBuilder.RenameTable(
                name: "Vendors",
                newName: "Vendor");

            migrationBuilder.RenameTable(
                name: "Purchases",
                newName: "Purchase");

            migrationBuilder.RenameTable(
                name: "PurchaseLists",
                newName: "PurchaseList");

            migrationBuilder.RenameIndex(
                name: "IX_Purchases_VendorId",
                table: "Purchase",
                newName: "IX_Purchase_VendorId");

            migrationBuilder.RenameIndex(
                name: "IX_Purchases_RegistrationId",
                table: "Purchase",
                newName: "IX_Purchase_RegistrationId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseLists_PurchaseId",
                table: "PurchaseList",
                newName: "IX_PurchaseList_PurchaseId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseLists_ProductId",
                table: "PurchaseList",
                newName: "IX_PurchaseList_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendor",
                table: "Vendor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Purchase",
                table: "Purchase",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseList",
                table: "PurchaseList",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLog_Purchase_PurchaseId",
                table: "ProductLog",
                column: "PurchaseId",
                principalTable: "Purchase",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStocks_PurchaseList_PurchaseListId",
                table: "ProductStocks",
                column: "PurchaseListId",
                principalTable: "PurchaseList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Registration_RegistrationId",
                table: "Purchase",
                column: "RegistrationId",
                principalTable: "Registration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Vendor_VendorId",
                table: "Purchase",
                column: "VendorId",
                principalTable: "Vendor",
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
                name: "FK_PurchaseList_Purchase_PurchaseId",
                table: "PurchaseList",
                column: "PurchaseId",
                principalTable: "Purchase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasePayment_Vendor_VendorId",
                table: "PurchasePayment",
                column: "VendorId",
                principalTable: "Vendor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasePaymentList_Purchase_PurchaseId",
                table: "PurchasePaymentList",
                column: "PurchaseId",
                principalTable: "Purchase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasePaymentReturnRecord_Purchase_PurchaseId",
                table: "PurchasePaymentReturnRecord",
                column: "PurchaseId",
                principalTable: "Purchase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Selling_Purchase_PurchaseId",
                table: "Selling",
                column: "PurchaseId",
                principalTable: "Purchase",
                principalColumn: "Id");
        }
    }
}
