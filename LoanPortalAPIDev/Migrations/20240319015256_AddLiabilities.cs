using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanPortalAPIDev.Migrations
{
    /// <inheritdoc />
    public partial class AddLiabilities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AL_Type",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "AL_amount",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "consolidate",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "creditLimit",
                table: "Assets");

            migrationBuilder.RenameColumn(
                name: "outstandingBalance",
                table: "Assets",
                newName: "assetAmount");

            migrationBuilder.RenameColumn(
                name: "AL_Type_code",
                table: "Assets",
                newName: "assetType");

            migrationBuilder.AddColumn<Guid>(
                name: "liabilitiesliabilityId",
                table: "PQLC_Loans",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Liabilities",
                columns: table => new
                {
                    liabilityId = table.Column<Guid>(type: "uuid", nullable: false),
                    appID = table.Column<Guid>(type: "uuid", nullable: false),
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    liabilityType = table.Column<string>(type: "text", nullable: true),
                    liabilityAmount = table.Column<double>(type: "double precision", nullable: false),
                    customDescription = table.Column<string>(type: "text", nullable: true),
                    consolidate = table.Column<bool>(type: "boolean", nullable: false),
                    creditLimit = table.Column<double>(type: "double precision", nullable: false),
                    outstandingBalance = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liabilities", x => x.liabilityId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PQLC_Loans_liabilitiesliabilityId",
                table: "PQLC_Loans",
                column: "liabilitiesliabilityId");

            migrationBuilder.AddForeignKey(
                name: "FK_PQLC_Loans_Liabilities_liabilitiesliabilityId",
                table: "PQLC_Loans",
                column: "liabilitiesliabilityId",
                principalTable: "Liabilities",
                principalColumn: "liabilityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PQLC_Loans_Liabilities_liabilitiesliabilityId",
                table: "PQLC_Loans");

            migrationBuilder.DropTable(
                name: "Liabilities");

            migrationBuilder.DropIndex(
                name: "IX_PQLC_Loans_liabilitiesliabilityId",
                table: "PQLC_Loans");

            migrationBuilder.DropColumn(
                name: "liabilitiesliabilityId",
                table: "PQLC_Loans");

            migrationBuilder.RenameColumn(
                name: "assetType",
                table: "Assets",
                newName: "AL_Type_code");

            migrationBuilder.RenameColumn(
                name: "assetAmount",
                table: "Assets",
                newName: "outstandingBalance");

            migrationBuilder.AddColumn<string>(
                name: "AL_Type",
                table: "Assets",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AL_amount",
                table: "Assets",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "consolidate",
                table: "Assets",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "creditLimit",
                table: "Assets",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
