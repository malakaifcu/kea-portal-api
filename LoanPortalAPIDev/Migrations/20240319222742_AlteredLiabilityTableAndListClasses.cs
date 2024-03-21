using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanPortalAPIDev.Migrations
{
    /// <inheritdoc />
    public partial class AlteredLiabilityTableAndListClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PQLC_Loans_Assets_assetsID",
                table: "PQLC_Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_PQLC_Loans_Expense_expensesID",
                table: "PQLC_Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_PQLC_Loans_Income_incomeID",
                table: "PQLC_Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_PQLC_Loans_Liabilities_liabilitiesID",
                table: "PQLC_Loans");

            migrationBuilder.DropIndex(
                name: "IX_PQLC_Loans_assetsID",
                table: "PQLC_Loans");

            migrationBuilder.DropIndex(
                name: "IX_PQLC_Loans_expensesID",
                table: "PQLC_Loans");

            migrationBuilder.DropIndex(
                name: "IX_PQLC_Loans_incomeID",
                table: "PQLC_Loans");

            migrationBuilder.DropIndex(
                name: "IX_PQLC_Loans_liabilitiesID",
                table: "PQLC_Loans");

            migrationBuilder.DropColumn(
                name: "assetsID",
                table: "PQLC_Loans");

            migrationBuilder.DropColumn(
                name: "expensesID",
                table: "PQLC_Loans");

            migrationBuilder.DropColumn(
                name: "incomeID",
                table: "PQLC_Loans");

            migrationBuilder.DropColumn(
                name: "liabilitiesID",
                table: "PQLC_Loans");

            migrationBuilder.AddColumn<Guid>(
                name: "PQLC_LoanID",
                table: "Liabilities",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "liabilityAmountFreq",
                table: "Liabilities",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PQLC_LoanID",
                table: "Income",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PQLC_LoanID",
                table: "Expense",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PQLC_LoanID",
                table: "Assets",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Liabilities_PQLC_LoanID",
                table: "Liabilities",
                column: "PQLC_LoanID");

            migrationBuilder.CreateIndex(
                name: "IX_Income_PQLC_LoanID",
                table: "Income",
                column: "PQLC_LoanID");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_PQLC_LoanID",
                table: "Expense",
                column: "PQLC_LoanID");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_PQLC_LoanID",
                table: "Assets",
                column: "PQLC_LoanID");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_PQLC_Loans_PQLC_LoanID",
                table: "Assets",
                column: "PQLC_LoanID",
                principalTable: "PQLC_Loans",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_PQLC_Loans_PQLC_LoanID",
                table: "Expense",
                column: "PQLC_LoanID",
                principalTable: "PQLC_Loans",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Income_PQLC_Loans_PQLC_LoanID",
                table: "Income",
                column: "PQLC_LoanID",
                principalTable: "PQLC_Loans",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Liabilities_PQLC_Loans_PQLC_LoanID",
                table: "Liabilities",
                column: "PQLC_LoanID",
                principalTable: "PQLC_Loans",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_PQLC_Loans_PQLC_LoanID",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Expense_PQLC_Loans_PQLC_LoanID",
                table: "Expense");

            migrationBuilder.DropForeignKey(
                name: "FK_Income_PQLC_Loans_PQLC_LoanID",
                table: "Income");

            migrationBuilder.DropForeignKey(
                name: "FK_Liabilities_PQLC_Loans_PQLC_LoanID",
                table: "Liabilities");

            migrationBuilder.DropIndex(
                name: "IX_Liabilities_PQLC_LoanID",
                table: "Liabilities");

            migrationBuilder.DropIndex(
                name: "IX_Income_PQLC_LoanID",
                table: "Income");

            migrationBuilder.DropIndex(
                name: "IX_Expense_PQLC_LoanID",
                table: "Expense");

            migrationBuilder.DropIndex(
                name: "IX_Assets_PQLC_LoanID",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "PQLC_LoanID",
                table: "Liabilities");

            migrationBuilder.DropColumn(
                name: "liabilityAmountFreq",
                table: "Liabilities");

            migrationBuilder.DropColumn(
                name: "PQLC_LoanID",
                table: "Income");

            migrationBuilder.DropColumn(
                name: "PQLC_LoanID",
                table: "Expense");

            migrationBuilder.DropColumn(
                name: "PQLC_LoanID",
                table: "Assets");

            migrationBuilder.AddColumn<Guid>(
                name: "assetsID",
                table: "PQLC_Loans",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "expensesID",
                table: "PQLC_Loans",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "incomeID",
                table: "PQLC_Loans",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "liabilitiesID",
                table: "PQLC_Loans",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PQLC_Loans_assetsID",
                table: "PQLC_Loans",
                column: "assetsID");

            migrationBuilder.CreateIndex(
                name: "IX_PQLC_Loans_expensesID",
                table: "PQLC_Loans",
                column: "expensesID");

            migrationBuilder.CreateIndex(
                name: "IX_PQLC_Loans_incomeID",
                table: "PQLC_Loans",
                column: "incomeID");

            migrationBuilder.CreateIndex(
                name: "IX_PQLC_Loans_liabilitiesID",
                table: "PQLC_Loans",
                column: "liabilitiesID");

            migrationBuilder.AddForeignKey(
                name: "FK_PQLC_Loans_Assets_assetsID",
                table: "PQLC_Loans",
                column: "assetsID",
                principalTable: "Assets",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PQLC_Loans_Expense_expensesID",
                table: "PQLC_Loans",
                column: "expensesID",
                principalTable: "Expense",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PQLC_Loans_Income_incomeID",
                table: "PQLC_Loans",
                column: "incomeID",
                principalTable: "Income",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PQLC_Loans_Liabilities_liabilitiesID",
                table: "PQLC_Loans",
                column: "liabilitiesID",
                principalTable: "Liabilities",
                principalColumn: "ID");
        }
    }
}
