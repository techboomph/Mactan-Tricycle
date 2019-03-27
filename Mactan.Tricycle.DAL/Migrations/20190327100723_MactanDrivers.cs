using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Mactan.Tricycle.DAL.Migrations
{
    public partial class MactanDrivers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChargeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChargeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    DriversLicense = table.Column<string>(maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: true),
                    DriverLicenseExpiry = table.Column<DateTime>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    MaritalStatus = table.Column<string>(maxLength: 10, nullable: true),
                    ContactNo = table.Column<string>(maxLength: 20, nullable: true),
                    FacebookAccount = table.Column<string>(maxLength: 50, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MTUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Username = table.Column<string>(maxLength: 20, nullable: true),
                    Password = table.Column<string>(maxLength: 200, nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    ContactNo = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MTUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OwnerOrganizations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    OwnerOrganizationName = table.Column<string>(maxLength: 100, nullable: true),
                    RepresentFirstName = table.Column<string>(maxLength: 50, nullable: true),
                    RepresentLastName = table.Column<string>(maxLength: 50, nullable: true),
                    RepresentMiddleName = table.Column<string>(maxLength: 50, nullable: true),
                    RepresentContactNo = table.Column<string>(maxLength: 20, nullable: true),
                    RepresentAddress = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerOrganizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Key = table.Column<string>(maxLength: 50, nullable: true),
                    Value = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemConfigs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Code = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuditHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    TableName = table.Column<string>(maxLength: 50, nullable: true),
                    ColumnName = table.Column<string>(maxLength: 50, nullable: true),
                    OldValue = table.Column<string>(maxLength: 200, nullable: true),
                    NewValue = table.Column<string>(maxLength: 200, nullable: true),
                    MTUserId = table.Column<int>(nullable: false),
                    AuditHistoryTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditHistories_MTUsers_MTUserId",
                        column: x => x.MTUserId,
                        principalTable: "MTUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    FranchiseKey = table.Column<string>(nullable: true),
                    AssetCost = table.Column<double>(nullable: true),
                    FranchiseRenewalDate = table.Column<DateTime>(nullable: false),
                    AssetConfiguration = table.Column<string>(nullable: true),
                    LLCSPNo = table.Column<string>(nullable: true),
                    VehicleCode = table.Column<string>(maxLength: 10, nullable: true),
                    EngineNo = table.Column<string>(maxLength: 50, nullable: true),
                    ChassisNo = table.Column<string>(maxLength: 100, nullable: true),
                    VehicleRenewalDate = table.Column<DateTime>(nullable: true),
                    Manufacturer = table.Column<string>(maxLength: 100, nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    ORCRNo = table.Column<string>(maxLength: 20, nullable: true),
                    AssetType = table.Column<string>(maxLength: 150, nullable: true),
                    OwnerOrganizationId = table.Column<int>(nullable: false),
                    AssetPartId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assets_Assets_AssetPartId",
                        column: x => x.AssetPartId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assets_OwnerOrganizations_OwnerOrganizationId",
                        column: x => x.OwnerOrganizationId,
                        principalTable: "OwnerOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssetDrivers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    AssetId = table.Column<int>(nullable: false),
                    DriverId = table.Column<int>(nullable: false),
                    Rental = table.Column<double>(nullable: false),
                    RentalConfig = table.Column<double>(nullable: false),
                    ContractMonth = table.Column<int>(nullable: false),
                    DateStarted = table.Column<DateTime>(nullable: false),
                    DateFinishedActual = table.Column<DateTime>(nullable: false),
                    DateFinishedExpected = table.Column<DateTime>(nullable: false),
                    ContractType = table.Column<string>(maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetDrivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetDrivers_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetDrivers_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Charges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    ChargeTypeId = table.Column<int>(nullable: false),
                    ChargeAmount = table.Column<double>(nullable: false),
                    ChargeDate = table.Column<DateTime>(nullable: false),
                    DriverId = table.Column<int>(nullable: false),
                    AssetDriverId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    TransactionTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Charges_AssetDrivers_AssetDriverId",
                        column: x => x.AssetDriverId,
                        principalTable: "AssetDrivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Charges_ChargeTypes_ChargeTypeId",
                        column: x => x.ChargeTypeId,
                        principalTable: "ChargeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Charges_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Charges_TransactionTypes_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    MTUserId = table.Column<int>(nullable: false),
                    ChargeId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    TransactionTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentTransactions_Charges_ChargeId",
                        column: x => x.ChargeId,
                        principalTable: "Charges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentTransactions_MTUsers_MTUserId",
                        column: x => x.MTUserId,
                        principalTable: "MTUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentTransactions_TransactionTypes_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssetDrivers_AssetId",
                table: "AssetDrivers",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDrivers_DriverId",
                table: "AssetDrivers",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_AssetPartId",
                table: "Assets",
                column: "AssetPartId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_OwnerOrganizationId",
                table: "Assets",
                column: "OwnerOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditHistories_MTUserId",
                table: "AuditHistories",
                column: "MTUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Charges_AssetDriverId",
                table: "Charges",
                column: "AssetDriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Charges_ChargeTypeId",
                table: "Charges",
                column: "ChargeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Charges_DriverId",
                table: "Charges",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Charges_TransactionTypeId",
                table: "Charges",
                column: "TransactionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTransactions_ChargeId",
                table: "PaymentTransactions",
                column: "ChargeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTransactions_MTUserId",
                table: "PaymentTransactions",
                column: "MTUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTransactions_TransactionTypeId",
                table: "PaymentTransactions",
                column: "TransactionTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditHistories");

            migrationBuilder.DropTable(
                name: "PaymentTransactions");

            migrationBuilder.DropTable(
                name: "SystemConfigs");

            migrationBuilder.DropTable(
                name: "Charges");

            migrationBuilder.DropTable(
                name: "MTUsers");

            migrationBuilder.DropTable(
                name: "AssetDrivers");

            migrationBuilder.DropTable(
                name: "ChargeTypes");

            migrationBuilder.DropTable(
                name: "TransactionTypes");

            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "OwnerOrganizations");
        }
    }
}
