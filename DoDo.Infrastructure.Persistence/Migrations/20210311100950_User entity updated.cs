using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoDo.Infrastructure.Persistence.Migrations
{
    public partial class Userentityupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PremiumSubscriptionId",
                table: "_Users");

            migrationBuilder.AlterColumn<int>(
                name: "GoogleId",
                table: "_Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "_Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "DateFormat",
                table: "_Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "JoinDate",
                table: "_Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Language",
                table: "_Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PremiumSubscriptionUntil",
                table: "_Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StartDayOfWeek",
                table: "_Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Theme",
                table: "_Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TimeFormat",
                table: "_Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateFormat",
                table: "_Users");

            migrationBuilder.DropColumn(
                name: "JoinDate",
                table: "_Users");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "_Users");

            migrationBuilder.DropColumn(
                name: "PremiumSubscriptionUntil",
                table: "_Users");

            migrationBuilder.DropColumn(
                name: "StartDayOfWeek",
                table: "_Users");

            migrationBuilder.DropColumn(
                name: "Theme",
                table: "_Users");

            migrationBuilder.DropColumn(
                name: "TimeFormat",
                table: "_Users");

            migrationBuilder.AlterColumn<int>(
                name: "GoogleId",
                table: "_Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "_Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PremiumSubscriptionId",
                table: "_Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
