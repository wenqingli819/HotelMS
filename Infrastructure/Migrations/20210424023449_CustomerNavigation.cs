using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class CustomerNavigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoomCode",
                table: "Customer",
                newName: "RoomId");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Service",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Service_CustomerId",
                table: "Service",
                column: "CustomerId");

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
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Customer_CustomerId",
                table: "Service",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Room_RoomId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Customer_CustomerId",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_Service_CustomerId",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_Customer_RoomId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Service");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Customer",
                newName: "RoomCode");
        }
    }
}
