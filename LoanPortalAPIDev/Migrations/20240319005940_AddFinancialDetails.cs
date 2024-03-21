using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanPortalAPIDev.Migrations
{
    /// <inheritdoc />
    public partial class AddFinancialDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "firstPaymentDate",
                table: "PQLC_Loans",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "householdAdult",
                table: "PQLC_Loans",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "householdDependants",
                table: "PQLC_Loans",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "instalmentAmount",
                table: "PQLC_Loans",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "instalmentFrequency",
                table: "PQLC_Loans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "interestAccrued",
                table: "PQLC_Loans",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "maturityDate",
                table: "PQLC_Loans",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "startDate",
                table: "PQLC_Loans",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "firstPaymentDate",
                table: "PQLC_Loans");

            migrationBuilder.DropColumn(
                name: "householdAdult",
                table: "PQLC_Loans");

            migrationBuilder.DropColumn(
                name: "householdDependants",
                table: "PQLC_Loans");

            migrationBuilder.DropColumn(
                name: "instalmentAmount",
                table: "PQLC_Loans");

            migrationBuilder.DropColumn(
                name: "instalmentFrequency",
                table: "PQLC_Loans");

            migrationBuilder.DropColumn(
                name: "interestAccrued",
                table: "PQLC_Loans");

            migrationBuilder.DropColumn(
                name: "maturityDate",
                table: "PQLC_Loans");

            migrationBuilder.DropColumn(
                name: "startDate",
                table: "PQLC_Loans");
        }
    }
}
