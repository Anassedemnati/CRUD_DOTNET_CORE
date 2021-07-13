using Microsoft.EntityFrameworkCore.Migrations;

namespace inandout.Migrations
{
    public partial class foreingKeyBtwExpensesANDcATEG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "categoryId",
                table: "Expense",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Expense_categoryId",
                table: "Expense",
                column: "categoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_ExpensesCategorys_categoryId",
                table: "Expense",
                column: "categoryId",
                principalTable: "ExpensesCategorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expense_ExpensesCategorys_categoryId",
                table: "Expense");

            migrationBuilder.DropIndex(
                name: "IX_Expense_categoryId",
                table: "Expense");

            migrationBuilder.DropColumn(
                name: "categoryId",
                table: "Expense");
        }
    }
}
