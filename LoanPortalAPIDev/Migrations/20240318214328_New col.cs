using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanPortalAPIDev.Migrations
{
    /// <inheritdoc />
    public partial class Newcol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "financeRate",
                table: "PQLC_Loans",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "loanTerm",
                table: "PQLC_Loans",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "termType",
                table: "PQLC_Loans",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "financeRate",
                table: "PQLC_Loans");

            migrationBuilder.DropColumn(
                name: "loanTerm",
                table: "PQLC_Loans");

            migrationBuilder.DropColumn(
                name: "termType",
                table: "PQLC_Loans");
        }
    }
}
