using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class productlogandchangespurchase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductLog_ProductStocks_ProductStockId",
                table: "ProductLog");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLog_Purchases_PurchaseId",
                table: "ProductLog");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLog_Registration_RegistrationId",
                table: "ProductLog");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLog_Selling_SellingId",
                table: "ProductLog");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasePaymentReturnRecord_Account_AccountId",
                table: "PurchasePaymentReturnRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasePaymentReturnRecord_Purchases_PurchaseId",
                table: "PurchasePaymentReturnRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasePaymentReturnRecord_Registration_RegistrationId",
                table: "PurchasePaymentReturnRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Registration_RegistrationId",
                table: "Purchases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchasePaymentReturnRecord",
                table: "PurchasePaymentReturnRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductLog",
                table: "ProductLog");

            migrationBuilder.DropColumn(
                name: "ActivityByRegistrationId",
                table: "ProductLog");

            migrationBuilder.RenameTable(
                name: "PurchasePaymentReturnRecord",
                newName: "PurchasePaymentReturnRecords");

            migrationBuilder.RenameTable(
                name: "ProductLog",
                newName: "ProductLogs");

            migrationBuilder.RenameColumn(
                name: "InsertDate",
                table: "Purchases",
                newName: "UpdateAt");

            migrationBuilder.RenameIndex(
                name: "IX_PurchasePaymentReturnRecord_RegistrationId",
                table: "PurchasePaymentReturnRecords",
                newName: "IX_PurchasePaymentReturnRecords_RegistrationId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchasePaymentReturnRecord_PurchaseId",
                table: "PurchasePaymentReturnRecords",
                newName: "IX_PurchasePaymentReturnRecords_PurchaseId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchasePaymentReturnRecord_AccountId",
                table: "PurchasePaymentReturnRecords",
                newName: "IX_PurchasePaymentReturnRecords_AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductLog_SellingId",
                table: "ProductLogs",
                newName: "IX_ProductLogs_SellingId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductLog_RegistrationId",
                table: "ProductLogs",
                newName: "IX_ProductLogs_RegistrationId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductLog_PurchaseId",
                table: "ProductLogs",
                newName: "IX_ProductLogs_PurchaseId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductLog_ProductStockId",
                table: "ProductLogs",
                newName: "IX_ProductLogs_ProductStockId");

            migrationBuilder.AlterColumn<int>(
                name: "RegistrationId",
                table: "Purchases",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseItemTime",
                table: "PurchaseLists",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "RegistrationId",
                table: "ProductLogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchasePaymentReturnRecords",
                table: "PurchasePaymentReturnRecords",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductLogs",
                table: "ProductLogs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLogs_ProductStocks_ProductStockId",
                table: "ProductLogs",
                column: "ProductStockId",
                principalTable: "ProductStocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLogs_Purchases_PurchaseId",
                table: "ProductLogs",
                column: "PurchaseId",
                principalTable: "Purchases",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLogs_Registration_RegistrationId",
                table: "ProductLogs",
                column: "RegistrationId",
                principalTable: "Registration",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLogs_Selling_SellingId",
                table: "ProductLogs",
                column: "SellingId",
                principalTable: "Selling",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasePaymentReturnRecords_Account_AccountId",
                table: "PurchasePaymentReturnRecords",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasePaymentReturnRecords_Purchases_PurchaseId",
                table: "PurchasePaymentReturnRecords",
                column: "PurchaseId",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasePaymentReturnRecords_Registration_RegistrationId",
                table: "PurchasePaymentReturnRecords",
                column: "RegistrationId",
                principalTable: "Registration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Registration_RegistrationId",
                table: "Purchases",
                column: "RegistrationId",
                principalTable: "Registration",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductLogs_ProductStocks_ProductStockId",
                table: "ProductLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLogs_Purchases_PurchaseId",
                table: "ProductLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLogs_Registration_RegistrationId",
                table: "ProductLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLogs_Selling_SellingId",
                table: "ProductLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasePaymentReturnRecords_Account_AccountId",
                table: "PurchasePaymentReturnRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasePaymentReturnRecords_Purchases_PurchaseId",
                table: "PurchasePaymentReturnRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasePaymentReturnRecords_Registration_RegistrationId",
                table: "PurchasePaymentReturnRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Registration_RegistrationId",
                table: "Purchases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchasePaymentReturnRecords",
                table: "PurchasePaymentReturnRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductLogs",
                table: "ProductLogs");

            migrationBuilder.DropColumn(
                name: "PurchaseItemTime",
                table: "PurchaseLists");

            migrationBuilder.RenameTable(
                name: "PurchasePaymentReturnRecords",
                newName: "PurchasePaymentReturnRecord");

            migrationBuilder.RenameTable(
                name: "ProductLogs",
                newName: "ProductLog");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "Purchases",
                newName: "InsertDate");

            migrationBuilder.RenameIndex(
                name: "IX_PurchasePaymentReturnRecords_RegistrationId",
                table: "PurchasePaymentReturnRecord",
                newName: "IX_PurchasePaymentReturnRecord_RegistrationId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchasePaymentReturnRecords_PurchaseId",
                table: "PurchasePaymentReturnRecord",
                newName: "IX_PurchasePaymentReturnRecord_PurchaseId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchasePaymentReturnRecords_AccountId",
                table: "PurchasePaymentReturnRecord",
                newName: "IX_PurchasePaymentReturnRecord_AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductLogs_SellingId",
                table: "ProductLog",
                newName: "IX_ProductLog_SellingId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductLogs_RegistrationId",
                table: "ProductLog",
                newName: "IX_ProductLog_RegistrationId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductLogs_PurchaseId",
                table: "ProductLog",
                newName: "IX_ProductLog_PurchaseId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductLogs_ProductStockId",
                table: "ProductLog",
                newName: "IX_ProductLog_ProductStockId");

            migrationBuilder.AlterColumn<int>(
                name: "RegistrationId",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RegistrationId",
                table: "ProductLog",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ActivityByRegistrationId",
                table: "ProductLog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchasePaymentReturnRecord",
                table: "PurchasePaymentReturnRecord",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductLog",
                table: "ProductLog",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLog_ProductStocks_ProductStockId",
                table: "ProductLog",
                column: "ProductStockId",
                principalTable: "ProductStocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLog_Purchases_PurchaseId",
                table: "ProductLog",
                column: "PurchaseId",
                principalTable: "Purchases",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLog_Registration_RegistrationId",
                table: "ProductLog",
                column: "RegistrationId",
                principalTable: "Registration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLog_Selling_SellingId",
                table: "ProductLog",
                column: "SellingId",
                principalTable: "Selling",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasePaymentReturnRecord_Account_AccountId",
                table: "PurchasePaymentReturnRecord",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasePaymentReturnRecord_Purchases_PurchaseId",
                table: "PurchasePaymentReturnRecord",
                column: "PurchaseId",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasePaymentReturnRecord_Registration_RegistrationId",
                table: "PurchasePaymentReturnRecord",
                column: "RegistrationId",
                principalTable: "Registration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Registration_RegistrationId",
                table: "Purchases",
                column: "RegistrationId",
                principalTable: "Registration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
