using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class addnewfiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReveiverID",
                table: "customerAccountsProcess",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderID",
                table: "customerAccountsProcess",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_customerAccountsProcess_ReveiverID",
                table: "customerAccountsProcess",
                column: "ReveiverID");

            migrationBuilder.CreateIndex(
                name: "IX_customerAccountsProcess_SenderID",
                table: "customerAccountsProcess",
                column: "SenderID");

            migrationBuilder.AddForeignKey(
                name: "FK_customerAccountsProcess_customerAccounts_ReveiverID",
                table: "customerAccountsProcess",
                column: "ReveiverID",
                principalTable: "customerAccounts",
                principalColumn: "CustomerAccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_customerAccountsProcess_customerAccounts_SenderID",
                table: "customerAccountsProcess",
                column: "SenderID",
                principalTable: "customerAccounts",
                principalColumn: "CustomerAccountID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customerAccountsProcess_customerAccounts_ReveiverID",
                table: "customerAccountsProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_customerAccountsProcess_customerAccounts_SenderID",
                table: "customerAccountsProcess");

            migrationBuilder.DropIndex(
                name: "IX_customerAccountsProcess_ReveiverID",
                table: "customerAccountsProcess");

            migrationBuilder.DropIndex(
                name: "IX_customerAccountsProcess_SenderID",
                table: "customerAccountsProcess");

            migrationBuilder.DropColumn(
                name: "ReveiverID",
                table: "customerAccountsProcess");

            migrationBuilder.DropColumn(
                name: "SenderID",
                table: "customerAccountsProcess");
        }
    }
}
