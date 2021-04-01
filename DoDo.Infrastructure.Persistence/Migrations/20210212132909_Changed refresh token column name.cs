using Microsoft.EntityFrameworkCore.Migrations;

namespace DoDo.Infrastructure.Persistence.Migrations
{
    public partial class Changedrefreshtokencolumnname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Invoked",
                table: "RefreshToken",
                newName: "Revoked");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Revoked",
                table: "RefreshToken",
                newName: "Invoked");
        }
    }
}
