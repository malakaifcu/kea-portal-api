using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanPortalAPIDev.Migrations
{
    /// <inheritdoc />
    public partial class PrivatePKAssetLiability : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PQLC_Loans_Assets_assetsassetId",
                table: "PQLC_Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_PQLC_Loans_Liabilities_liabilitiesliabilityId",
                table: "PQLC_Loans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Liabilities",
                table: "Liabilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assets",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "liabilityId",
                table: "Liabilities");

            migrationBuilder.DropColumn(
                name: "assetId",
                table: "Assets");

            migrationBuilder.RenameColumn(
                name: "liabilitiesliabilityId",
                table: "PQLC_Loans",
                newName: "liabilitiesID");

            migrationBuilder.RenameColumn(
                name: "assetsassetId",
                table: "PQLC_Loans",
                newName: "assetsID");

            migrationBuilder.RenameIndex(
                name: "IX_PQLC_Loans_liabilitiesliabilityId",
                table: "PQLC_Loans",
                newName: "IX_PQLC_Loans_liabilitiesID");

            migrationBuilder.RenameIndex(
                name: "IX_PQLC_Loans_assetsassetId",
                table: "PQLC_Loans",
                newName: "IX_PQLC_Loans_assetsID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Liabilities",
                table: "Liabilities",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assets",
                table: "Assets",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PQLC_Loans_Assets_assetsID",
                table: "PQLC_Loans",
                column: "assetsID",
                principalTable: "Assets",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PQLC_Loans_Liabilities_liabilitiesID",
                table: "PQLC_Loans",
                column: "liabilitiesID",
                principalTable: "Liabilities",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PQLC_Loans_Assets_assetsID",
                table: "PQLC_Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_PQLC_Loans_Liabilities_liabilitiesID",
                table: "PQLC_Loans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Liabilities",
                table: "Liabilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assets",
                table: "Assets");

            migrationBuilder.RenameColumn(
                name: "liabilitiesID",
                table: "PQLC_Loans",
                newName: "liabilitiesliabilityId");

            migrationBuilder.RenameColumn(
                name: "assetsID",
                table: "PQLC_Loans",
                newName: "assetsassetId");

            migrationBuilder.RenameIndex(
                name: "IX_PQLC_Loans_liabilitiesID",
                table: "PQLC_Loans",
                newName: "IX_PQLC_Loans_liabilitiesliabilityId");

            migrationBuilder.RenameIndex(
                name: "IX_PQLC_Loans_assetsID",
                table: "PQLC_Loans",
                newName: "IX_PQLC_Loans_assetsassetId");

            migrationBuilder.AddColumn<Guid>(
                name: "liabilityId",
                table: "Liabilities",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "assetId",
                table: "Assets",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Liabilities",
                table: "Liabilities",
                column: "liabilityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assets",
                table: "Assets",
                column: "assetId");

            migrationBuilder.AddForeignKey(
                name: "FK_PQLC_Loans_Assets_assetsassetId",
                table: "PQLC_Loans",
                column: "assetsassetId",
                principalTable: "Assets",
                principalColumn: "assetId");

            migrationBuilder.AddForeignKey(
                name: "FK_PQLC_Loans_Liabilities_liabilitiesliabilityId",
                table: "PQLC_Loans",
                column: "liabilitiesliabilityId",
                principalTable: "Liabilities",
                principalColumn: "liabilityId");
        }
    }
}
