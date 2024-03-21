using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanPortalAPIDev.Migrations
{
    /// <inheritdoc />
    public partial class AddAssets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "assetsassetId",
                table: "PQLC_Loans",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    assetId = table.Column<Guid>(type: "uuid", nullable: false),
                    appID = table.Column<Guid>(type: "uuid", nullable: false),
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    AL_Type = table.Column<string>(type: "text", nullable: true),
                    AL_Type_code = table.Column<string>(type: "text", nullable: true),
                    AL_amount = table.Column<double>(type: "double precision", nullable: false),
                    customDescription = table.Column<string>(type: "text", nullable: true),
                    consolidate = table.Column<bool>(type: "boolean", nullable: false),
                    creditLimit = table.Column<double>(type: "double precision", nullable: false),
                    outstandingBalance = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.assetId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PQLC_Loans_assetsassetId",
                table: "PQLC_Loans",
                column: "assetsassetId");

            migrationBuilder.AddForeignKey(
                name: "FK_PQLC_Loans_Assets_assetsassetId",
                table: "PQLC_Loans",
                column: "assetsassetId",
                principalTable: "Assets",
                principalColumn: "assetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PQLC_Loans_Assets_assetsassetId",
                table: "PQLC_Loans");

            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_PQLC_Loans_assetsassetId",
                table: "PQLC_Loans");

            migrationBuilder.DropColumn(
                name: "assetsassetId",
                table: "PQLC_Loans");
        }
    }
}
