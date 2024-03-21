using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanPortalAPIDev.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PQLC_Loans",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    applicationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    lastSavedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    applicationName = table.Column<string>(type: "text", nullable: true),
                    clientNumber = table.Column<string>(type: "text", nullable: true),
                    actionedBy = table.Column<string>(type: "text", nullable: true),
                    loanProduct = table.Column<string>(type: "text", nullable: true),
                    existingLoanBalance = table.Column<double>(type: "double precision", nullable: false),
                    proposedLoanBalance = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PQLC_Loans", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PQLC_Loans");
        }
    }
}
