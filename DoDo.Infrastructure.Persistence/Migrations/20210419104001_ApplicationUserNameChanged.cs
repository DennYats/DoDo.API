using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoDo.Infrastructure.Persistence.Migrations
{
    public partial class ApplicationUserNameChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RepeatIn",
                table: "ToDoItems",
                newName: "ReccurentInterval");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ToDoSubTasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ToDoLists",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ToDoItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsReccurent",
                table: "ToDoItems",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ToDoSubTasks");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ToDoLists");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ToDoItems");

            migrationBuilder.DropColumn(
                name: "IsReccurent",
                table: "ToDoItems");

            migrationBuilder.RenameColumn(
                name: "ReccurentInterval",
                table: "ToDoItems",
                newName: "RepeatIn");
        }
    }
}
