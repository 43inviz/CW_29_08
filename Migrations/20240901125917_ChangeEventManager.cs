using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CW_30_08.Migrations
{
    /// <inheritdoc />
    public partial class ChangeEventManager : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventDate",
                table: "EventManagers");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "EventManagers",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<DateTime>(
                name: "EventDateTime",
                table: "EventManagers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventDateTime",
                table: "EventManagers");

            migrationBuilder.AlterColumn<int>(
                name: "Description",
                table: "EventManagers",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "EventDate",
                table: "EventManagers",
                type: "TEXT",
                nullable: true);
        }
    }
}
