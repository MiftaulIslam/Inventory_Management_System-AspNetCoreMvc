using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class initilizing_ProductcatalogType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CostPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InstitutionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReturnAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Paid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccountTransactionCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Due = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseAdjustedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DueLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsIndividual = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PageLinkCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sn = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageLinkCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCatalogTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatalogType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCatalogTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Validation = table.Column<bool>(type: "bit", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReturnAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Paid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Due = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountDeposit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    DepositAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepositDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountDeposit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountDeposit_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccountWithdraw",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    WithdrawAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WithdrawDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountWithdraw", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountWithdraw_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Institution",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucherCountdown = table.Column<int>(type: "int", nullable: false),
                    InstitutionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DialogTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Established = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstitutionLogo = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DefaultAccountId = table.Column<int>(type: "int", nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    Capital = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institution", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Institution_Account_DefaultAccountId",
                        column: x => x.DefaultAccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerPhone",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPhone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerPhone_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PageLink",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkCategoryId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Controller = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sn = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PageLink_PageLinkCategory_LinkCategoryId",
                        column: x => x.LinkCategoryId,
                        principalTable: "PageLinkCategory",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductCatalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatalogTypeId = table.Column<int>(type: "int", nullable: true),
                    CatalogName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatalogLevel = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    ItemCount = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCatalog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCatalog_ProductCatalogTypes_CatalogTypeId",
                        column: x => x.CatalogTypeId,
                        principalTable: "ProductCatalogTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductCatalog_ProductCatalog_ParentId",
                        column: x => x.ParentId,
                        principalTable: "ProductCatalog",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdminMoneyCollection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    CollectionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminMoneyCollection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminMoneyCollection_Registration_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registration",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Expense",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucherNo = table.Column<int>(type: "int", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    ExpenseCategoryId = table.Column<int>(type: "int", nullable: false),
                    ExpenseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpenseFor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpenseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expense", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expense_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Expense_ExpenseCategory_ExpenseCategoryId",
                        column: x => x.ExpenseCategoryId,
                        principalTable: "ExpenseCategory",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Expense_Registration_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registration",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseTransportation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    VoucherNo = table.Column<int>(type: "int", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    TotalExpense = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpenseNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpenseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseTransportation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpenseTransportation_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExpenseTransportation_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExpenseTransportation_Registration_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registration",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SellingPayment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ReceiptSn = table.Column<int>(type: "int", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountTransactionCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaidDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    AccountCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccountCostPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellingPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SellingPayment_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SellingPayment_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SellingPayment_Registration_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registration",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ServiceSn = table.Column<int>(type: "int", nullable: false),
                    ServiceTotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServiceDiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServiceDiscountPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServicePaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServiceDueAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServicePaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Service_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Service_Registration_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registration",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    PurchaseSn = table.Column<int>(type: "int", nullable: false),
                    PurchaseTotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseDiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseDiscountPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchasePaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseReturnAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseDueAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchasePaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemoNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Purchase_Registration_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registration",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Purchase_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendor",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchasePayment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    ReceiptSn = table.Column<int>(type: "int", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaidDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasePayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchasePayment_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchasePayment_Registration_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registration",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchasePayment_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendor",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PageLinkAssign",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    LinkId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageLinkAssign", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PageLinkAssign_PageLink_LinkId",
                        column: x => x.LinkId,
                        principalTable: "PageLink",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PageLinkAssign_Registration_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registration",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCatalogId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Warranty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SellingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductCatalog_ProductCatalogId",
                        column: x => x.ProductCatalogId,
                        principalTable: "ProductCatalog",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceDevice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCatalogId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceDevice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceDevice_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceDevice_ProductCatalog_ProductCatalogId",
                        column: x => x.ProductCatalogId,
                        principalTable: "ProductCatalog",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseTransportationList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenseTransportationId = table.Column<int>(type: "int", nullable: false),
                    NumberOfPerson = table.Column<int>(type: "int", nullable: false),
                    ExpenseFor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vehicle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpenseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseTransportationList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpenseTransportationList_ExpenseTransportation_ExpenseTransportationId",
                        column: x => x.ExpenseTransportationId,
                        principalTable: "ExpenseTransportation",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServicePaymentList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellingPaymentId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    ServicePaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePaymentList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServicePaymentList_SellingPayment_SellingPaymentId",
                        column: x => x.SellingPaymentId,
                        principalTable: "SellingPayment",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServicePaymentList_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchasePaymentReturnRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrevReturnAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrentReturnAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetReturnAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    InsertDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PurchaseId = table.Column<int>(type: "int", nullable: false),
                    RegistrationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasePaymentReturnRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchasePaymentReturnRecord_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchasePaymentReturnRecord_Purchase_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "Purchase",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchasePaymentReturnRecord_Registration_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registration",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Selling",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    SellingSn = table.Column<int>(type: "int", nullable: false),
                    SellingTotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellingDiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellingDiscountPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellingPaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellingReturnAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellingDueAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellingPaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SellingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PromisedPaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ServiceCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServiceCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServiceChargeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpenseTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccountTransactionCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BuyingTotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellingAccountCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServiceProfit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellingProfit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellingNetProfit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrandProfit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseAdjustedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchaseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Selling", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Selling_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Selling_Purchase_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "Purchase",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Selling_Registration_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registration",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchasePaymentList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchasePaymentId = table.Column<int>(type: "int", nullable: false),
                    PurchaseId = table.Column<int>(type: "int", nullable: false),
                    PurchasePaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasePaymentList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchasePaymentList_PurchasePayment_PurchasePaymentId",
                        column: x => x.PurchasePaymentId,
                        principalTable: "PurchasePayment",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchasePaymentList_Purchase_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "Purchase",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Warranty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SellingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseList_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseList_Purchase_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "Purchase",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    ServiceDeviceId = table.Column<int>(type: "int", nullable: false),
                    ServiceCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Problem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Solution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceList_ServiceDevice_ServiceDeviceId",
                        column: x => x.ServiceDeviceId,
                        principalTable: "ServiceDevice",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceList_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SellingExpense",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellingId = table.Column<int>(type: "int", nullable: false),
                    Expense = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpenseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellingExpense", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SellingExpense_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SellingExpense_Selling_SellingId",
                        column: x => x.SellingId,
                        principalTable: "Selling",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SellingList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellingId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SellingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Warranty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellingList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SellingList_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SellingList_Selling_SellingId",
                        column: x => x.SellingId,
                        principalTable: "Selling",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SellingPaymentList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellingPaymentId = table.Column<int>(type: "int", nullable: false),
                    SellingId = table.Column<int>(type: "int", nullable: false),
                    SellingPaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccountTransactionCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellingPaymentList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SellingPaymentList_SellingPayment_SellingPaymentId",
                        column: x => x.SellingPaymentId,
                        principalTable: "SellingPayment",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SellingPaymentList_Selling_SellingId",
                        column: x => x.SellingId,
                        principalTable: "Selling",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SellingPaymentReturnRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrevReturnAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrentReturnAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetReturnAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    InsertDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SellingId = table.Column<int>(type: "int", nullable: false),
                    RegistrationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellingPaymentReturnRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SellingPaymentReturnRecord_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SellingPaymentReturnRecord_Registration_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registration",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SellingPaymentReturnRecord_Selling_SellingId",
                        column: x => x.SellingId,
                        principalTable: "Selling",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SellingPromiseDateMiss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    SellingId = table.Column<int>(type: "int", nullable: false),
                    MissDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellingPromiseDateMiss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SellingPromiseDateMiss_Registration_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registration",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SellingPromiseDateMiss_Selling_SellingId",
                        column: x => x.SellingId,
                        principalTable: "Selling",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductStock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SellingListId = table.Column<int>(type: "int", nullable: true),
                    PurchaseListId = table.Column<int>(type: "int", nullable: false),
                    IsSold = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductStock_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductStock_PurchaseList_PurchaseListId",
                        column: x => x.PurchaseListId,
                        principalTable: "PurchaseList",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductStock_SellingList_SellingListId",
                        column: x => x.SellingListId,
                        principalTable: "SellingList",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductDamaged",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductStockId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DamagedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDamaged", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDamaged_ProductStock_ProductStockId",
                        column: x => x.ProductStockId,
                        principalTable: "ProductStock",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductStockId = table.Column<int>(type: "int", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActivityByRegistrationId = table.Column<int>(type: "int", nullable: false),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    SellingId = table.Column<int>(type: "int", nullable: true),
                    PurchaseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductLog_ProductStock_ProductStockId",
                        column: x => x.ProductStockId,
                        principalTable: "ProductStock",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductLog_Purchase_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "Purchase",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductLog_Registration_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registration",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductLog_Selling_SellingId",
                        column: x => x.SellingId,
                        principalTable: "Selling",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SellingAdjustment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SellingId = table.Column<int>(type: "int", nullable: false),
                    ProductStockId = table.Column<int>(type: "int", nullable: false),
                    AdjustmentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellingAdjustment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SellingAdjustment_ProductStock_ProductStockId",
                        column: x => x.ProductStockId,
                        principalTable: "ProductStock",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SellingAdjustment_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SellingAdjustment_Registration_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registration",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SellingAdjustment_Selling_SellingId",
                        column: x => x.SellingId,
                        principalTable: "Selling",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Warranty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellingId = table.Column<int>(type: "int", nullable: false),
                    ProductStockId = table.Column<int>(type: "int", nullable: false),
                    ChangedProductCatalogId = table.Column<int>(type: "int", nullable: true),
                    WarrantySn = table.Column<int>(type: "int", nullable: false),
                    AcceptanceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcceptanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChangedProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChangedProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelivered = table.Column<bool>(type: "bit", nullable: false),
                    InsertDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductCatalogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warranty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Warranty_ProductCatalog_ProductCatalogId",
                        column: x => x.ProductCatalogId,
                        principalTable: "ProductCatalog",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Warranty_ProductStock_ProductStockId",
                        column: x => x.ProductStockId,
                        principalTable: "ProductStock",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Warranty_Selling_SellingId",
                        column: x => x.SellingId,
                        principalTable: "Selling",
                        principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountDeposit_AccountId",
                table: "AccountDeposit",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountWithdraw_AccountId",
                table: "AccountWithdraw",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminMoneyCollection_RegistrationId",
                table: "AdminMoneyCollection",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPhone_CustomerId",
                table: "CustomerPhone",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_AccountId",
                table: "Expense",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_ExpenseCategoryId",
                table: "Expense",
                column: "ExpenseCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_RegistrationId",
                table: "Expense",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseTransportation_AccountId",
                table: "ExpenseTransportation",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseTransportation_CustomerId",
                table: "ExpenseTransportation",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseTransportation_RegistrationId",
                table: "ExpenseTransportation",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseTransportationList_ExpenseTransportationId",
                table: "ExpenseTransportationList",
                column: "ExpenseTransportationId");

            migrationBuilder.CreateIndex(
                name: "IX_Institution_DefaultAccountId",
                table: "Institution",
                column: "DefaultAccountId",
                unique: true,
                filter: "[DefaultAccountId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PageLink_LinkCategoryId",
                table: "PageLink",
                column: "LinkCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PageLinkAssign_LinkId",
                table: "PageLinkAssign",
                column: "LinkId");

            migrationBuilder.CreateIndex(
                name: "IX_PageLinkAssign_RegistrationId",
                table: "PageLinkAssign",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCatalogId",
                table: "Product",
                column: "ProductCatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCatalog_CatalogTypeId",
                table: "ProductCatalog",
                column: "CatalogTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCatalog_ParentId",
                table: "ProductCatalog",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDamaged_ProductStockId",
                table: "ProductDamaged",
                column: "ProductStockId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductLog_ProductStockId",
                table: "ProductLog",
                column: "ProductStockId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductLog_PurchaseId",
                table: "ProductLog",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductLog_RegistrationId",
                table: "ProductLog",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductLog_SellingId",
                table: "ProductLog",
                column: "SellingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStock_ProductId",
                table: "ProductStock",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStock_PurchaseListId",
                table: "ProductStock",
                column: "PurchaseListId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStock_SellingListId",
                table: "ProductStock",
                column: "SellingListId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_RegistrationId",
                table: "Purchase",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_VendorId",
                table: "Purchase",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseList_ProductId",
                table: "PurchaseList",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseList_PurchaseId",
                table: "PurchaseList",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasePayment_AccountId",
                table: "PurchasePayment",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasePayment_RegistrationId",
                table: "PurchasePayment",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasePayment_VendorId",
                table: "PurchasePayment",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasePaymentList_PurchaseId",
                table: "PurchasePaymentList",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasePaymentList_PurchasePaymentId",
                table: "PurchasePaymentList",
                column: "PurchasePaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasePaymentReturnRecord_AccountId",
                table: "PurchasePaymentReturnRecord",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasePaymentReturnRecord_PurchaseId",
                table: "PurchasePaymentReturnRecord",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasePaymentReturnRecord_RegistrationId",
                table: "PurchasePaymentReturnRecord",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_Selling_CustomerId",
                table: "Selling",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Selling_PurchaseId",
                table: "Selling",
                column: "PurchaseId",
                unique: true,
                filter: "[PurchaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Selling_RegistrationId",
                table: "Selling",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingAdjustment_ProductId",
                table: "SellingAdjustment",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingAdjustment_ProductStockId",
                table: "SellingAdjustment",
                column: "ProductStockId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingAdjustment_RegistrationId",
                table: "SellingAdjustment",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingAdjustment_SellingId",
                table: "SellingAdjustment",
                column: "SellingId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingExpense_AccountId",
                table: "SellingExpense",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingExpense_SellingId",
                table: "SellingExpense",
                column: "SellingId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingList_ProductId",
                table: "SellingList",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingList_SellingId",
                table: "SellingList",
                column: "SellingId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingPayment_AccountId",
                table: "SellingPayment",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingPayment_CustomerId",
                table: "SellingPayment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingPayment_RegistrationId",
                table: "SellingPayment",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingPaymentList_SellingId",
                table: "SellingPaymentList",
                column: "SellingId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingPaymentList_SellingPaymentId",
                table: "SellingPaymentList",
                column: "SellingPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingPaymentReturnRecord_AccountId",
                table: "SellingPaymentReturnRecord",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingPaymentReturnRecord_RegistrationId",
                table: "SellingPaymentReturnRecord",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingPaymentReturnRecord_SellingId",
                table: "SellingPaymentReturnRecord",
                column: "SellingId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingPromiseDateMiss_RegistrationId",
                table: "SellingPromiseDateMiss",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_SellingPromiseDateMiss_SellingId",
                table: "SellingPromiseDateMiss",
                column: "SellingId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_CustomerId",
                table: "Service",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_RegistrationId",
                table: "Service",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceDevice_CustomerId",
                table: "ServiceDevice",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceDevice_ProductCatalogId",
                table: "ServiceDevice",
                column: "ProductCatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceList_ServiceDeviceId",
                table: "ServiceList",
                column: "ServiceDeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceList_ServiceId",
                table: "ServiceList",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePaymentList_SellingPaymentId",
                table: "ServicePaymentList",
                column: "SellingPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePaymentList_ServiceId",
                table: "ServicePaymentList",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Warranty_ProductCatalogId",
                table: "Warranty",
                column: "ProductCatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_Warranty_ProductStockId",
                table: "Warranty",
                column: "ProductStockId");

            migrationBuilder.CreateIndex(
                name: "IX_Warranty_SellingId",
                table: "Warranty",
                column: "SellingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountDeposit");

            migrationBuilder.DropTable(
                name: "AccountWithdraw");

            migrationBuilder.DropTable(
                name: "AdminMoneyCollection");

            migrationBuilder.DropTable(
                name: "CustomerPhone");

            migrationBuilder.DropTable(
                name: "Expense");

            migrationBuilder.DropTable(
                name: "ExpenseTransportationList");

            migrationBuilder.DropTable(
                name: "Institution");

            migrationBuilder.DropTable(
                name: "PageLinkAssign");

            migrationBuilder.DropTable(
                name: "ProductDamaged");

            migrationBuilder.DropTable(
                name: "ProductLog");

            migrationBuilder.DropTable(
                name: "PurchasePaymentList");

            migrationBuilder.DropTable(
                name: "PurchasePaymentReturnRecord");

            migrationBuilder.DropTable(
                name: "SellingAdjustment");

            migrationBuilder.DropTable(
                name: "SellingExpense");

            migrationBuilder.DropTable(
                name: "SellingPaymentList");

            migrationBuilder.DropTable(
                name: "SellingPaymentReturnRecord");

            migrationBuilder.DropTable(
                name: "SellingPromiseDateMiss");

            migrationBuilder.DropTable(
                name: "ServiceList");

            migrationBuilder.DropTable(
                name: "ServicePaymentList");

            migrationBuilder.DropTable(
                name: "Warranty");

            migrationBuilder.DropTable(
                name: "ExpenseCategory");

            migrationBuilder.DropTable(
                name: "ExpenseTransportation");

            migrationBuilder.DropTable(
                name: "PageLink");

            migrationBuilder.DropTable(
                name: "PurchasePayment");

            migrationBuilder.DropTable(
                name: "ServiceDevice");

            migrationBuilder.DropTable(
                name: "SellingPayment");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "ProductStock");

            migrationBuilder.DropTable(
                name: "PageLinkCategory");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "PurchaseList");

            migrationBuilder.DropTable(
                name: "SellingList");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Selling");

            migrationBuilder.DropTable(
                name: "ProductCatalog");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.DropTable(
                name: "ProductCatalogTypes");

            migrationBuilder.DropTable(
                name: "Registration");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.CreateTable(
                name: "BillType",
                columns: table => new
                {
                    BillTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillType", x => x.BillTypeId);
                });

            migrationBuilder.CreateTable(
                name: "CashBank",
                columns: table => new
                {
                    CashBankId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CashBankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashBank", x => x.CashBankId);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    CurrencyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.CurrencyId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerType",
                columns: table => new
                {
                    CustomerTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerType", x => x.CustomerTypeId);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceType",
                columns: table => new
                {
                    InvoiceTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceType", x => x.InvoiceTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentType",
                columns: table => new
                {
                    PaymentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentType", x => x.PaymentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    ProductTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.ProductTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseType",
                columns: table => new
                {
                    PurchaseTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchaseTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseType", x => x.PurchaseTypeId);
                });

            migrationBuilder.CreateTable(
                name: "SalesType",
                columns: table => new
                {
                    SalesTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesType", x => x.SalesTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentType",
                columns: table => new
                {
                    ShipmentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipmentTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentType", x => x.ShipmentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "UnitOfMeasure",
                columns: table => new
                {
                    UnitOfMeasureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitOfMeasureName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitOfMeasure", x => x.UnitOfMeasureId);
                });

            migrationBuilder.CreateTable(
                name: "VendorType",
                columns: table => new
                {
                    VendorTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorType", x => x.VendorTypeId);
                });
        }
    }
}
