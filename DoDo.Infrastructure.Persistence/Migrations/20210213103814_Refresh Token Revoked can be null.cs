using Microsoft.EntityFrameworkCore.Migrations;

namespace DoDo.Infrastructure.Persistence.Migrations
{
    public partial class RefreshTokenRevokedcanbenull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "RefreshToken");

            migrationBuilder.DropColumn(
                name: "IsExpired",
                table: "RefreshToken");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "RefreshToken",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsExpired",
                table: "RefreshToken",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
