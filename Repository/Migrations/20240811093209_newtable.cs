using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class newtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "customerAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_customerAccounts_AppUserID",
                table: "customerAccounts",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_customerAccounts_AspNetUsers_AppUserID",
                table: "customerAccounts",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customerAccounts_AspNetUsers_AppUserID",
                table: "customerAccounts");

            migrationBuilder.DropIndex(
                name: "IX_customerAccounts_AppUserID",
                table: "customerAccounts");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "customerAccounts");
        }
    }
}
