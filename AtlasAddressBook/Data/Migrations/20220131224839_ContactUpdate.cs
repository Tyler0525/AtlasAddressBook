using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtlasAddressBook.Data.Migrations
{
    public partial class ContactUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryContact_Conatcts_ContactsId",
                table: "CategoryContact");

            migrationBuilder.DropForeignKey(
                name: "FK_Conatcts_AspNetUsers_UserId",
                table: "Conatcts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Conatcts",
                table: "Conatcts");

            migrationBuilder.RenameTable(
                name: "Conatcts",
                newName: "Contacts");

            migrationBuilder.RenameIndex(
                name: "IX_Conatcts_UserId",
                table: "Contacts",
                newName: "IX_Contacts_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryContact_Contacts_ContactsId",
                table: "CategoryContact",
                column: "ContactsId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_AspNetUsers_UserId",
                table: "Contacts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryContact_Contacts_ContactsId",
                table: "CategoryContact");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_AspNetUsers_UserId",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Conatcts");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_UserId",
                table: "Conatcts",
                newName: "IX_Conatcts_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conatcts",
                table: "Conatcts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryContact_Conatcts_ContactsId",
                table: "CategoryContact",
                column: "ContactsId",
                principalTable: "Conatcts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Conatcts_AspNetUsers_UserId",
                table: "Conatcts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
