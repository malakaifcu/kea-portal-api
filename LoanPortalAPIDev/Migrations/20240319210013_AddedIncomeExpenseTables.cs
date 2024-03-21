using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanPortalAPIDev.Migrations
{
    /// <inheritdoc />
    public partial class AddedIncomeExpenseTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Expense",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    appID = table.Column<Guid>(type: "uuid", nullable: false),
                    expenseType = table.Column<string>(type: "text", nullable: true),
                    expenseAmount = table.Column<double>(type: "double precision", nullable: false),
                    expenseFrequency = table.Column<string>(type: "text", nullable: true),
                    customDescription = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expense", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Income",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    appID = table.Column<Guid>(type: "uuid", nullable: false),
                    incomeType = table.Column<string>(type: "text", nullable: true),
                    incomeAmount = table.Column<double>(type: "double precision", nullable: false),
                    incomeFrequency = table.Column<string>(type: "text", nullable: true),
                    customDescription = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Income", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PQLC_Loans_expensesID",
                table: "PQLC_Loans",
                column: "expensesID");

            migrationBuilder.CreateIndex(
                name: "IX_PQLC_Loans_incomeID",
                table: "PQLC_Loans",
                column: "incomeID");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PQLC_Loans_Expense_expensesID",
                table: "PQLC_Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_PQLC_Loans_Income_incomeID",
                table: "PQLC_Loans");

            migrationBuilder.DropTable(
                name: "Expense");

            migrationBuilder.DropTable(
                name: "Income");

            migrationBuilder.DropIndex(
                name: "IX_PQLC_Loans_expensesID",
                table: "PQLC_Loans");

            migrationBuilder.DropIndex(
                name: "IX_PQLC_Loans_incomeID",
                table: "PQLC_Loans");

            migrationBuilder.DropColumn(
                name: "expensesID",
                table: "PQLC_Loans");

            migrationBuilder.DropColumn(
                name: "incomeID",
                table: "PQLC_Loans");
        }
    }
}
