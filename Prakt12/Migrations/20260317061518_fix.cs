using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prakt12.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInterestGroup_InterestGroup_InterestGroupId",
                table: "UserInterestGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInterestGroup_Users_UserId",
                table: "UserInterestGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInterestGroup",
                table: "UserInterestGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InterestGroup",
                table: "InterestGroup");

            migrationBuilder.RenameTable(
                name: "UserInterestGroup",
                newName: "UserInterestGroups");

            migrationBuilder.RenameTable(
                name: "InterestGroup",
                newName: "InterestGroups");

            migrationBuilder.RenameIndex(
                name: "IX_UserInterestGroup_InterestGroupId",
                table: "UserInterestGroups",
                newName: "IX_UserInterestGroups_InterestGroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInterestGroups",
                table: "UserInterestGroups",
                columns: new[] { "UserId", "InterestGroupId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_InterestGroups",
                table: "InterestGroups",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInterestGroups_InterestGroups_InterestGroupId",
                table: "UserInterestGroups",
                column: "InterestGroupId",
                principalTable: "InterestGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInterestGroups_Users_UserId",
                table: "UserInterestGroups",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInterestGroups_InterestGroups_InterestGroupId",
                table: "UserInterestGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInterestGroups_Users_UserId",
                table: "UserInterestGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInterestGroups",
                table: "UserInterestGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InterestGroups",
                table: "InterestGroups");

            migrationBuilder.RenameTable(
                name: "UserInterestGroups",
                newName: "UserInterestGroup");

            migrationBuilder.RenameTable(
                name: "InterestGroups",
                newName: "InterestGroup");

            migrationBuilder.RenameIndex(
                name: "IX_UserInterestGroups_InterestGroupId",
                table: "UserInterestGroup",
                newName: "IX_UserInterestGroup_InterestGroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInterestGroup",
                table: "UserInterestGroup",
                columns: new[] { "UserId", "InterestGroupId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_InterestGroup",
                table: "InterestGroup",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInterestGroup_InterestGroup_InterestGroupId",
                table: "UserInterestGroup",
                column: "InterestGroupId",
                principalTable: "InterestGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInterestGroup_Users_UserId",
                table: "UserInterestGroup",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
