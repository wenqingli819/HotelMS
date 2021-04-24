using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class UpdateCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Room_RoomId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_RoomId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Service");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Customer",
                newName: "RoomCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoomCode",
                table: "Customer",
                newName: "RoomId");

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Customer_RoomId",
                table: "Customer",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Room_RoomId",
                table: "Customer",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
