using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prakt12.Migrations
{
    /// <inheritdoc />
    public partial class fixProfileId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserProfileID",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserProfileID",
                table: "Users",
                type: "int",
                nullable: true);
        }
    }
}
