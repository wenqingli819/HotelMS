using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Advance",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "BookingDays",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CheckIn",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "TotalPersons",
                table: "Customer");

            migrationBuilder.AddColumn<decimal>(
                name: "Advance",
                table: "Service",
                type: "decimal(10,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookingDays",
                table: "Service",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckIn",
                table: "Service",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalPersons",
                table: "Service",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Advance",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "BookingDays",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "CheckIn",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "TotalPersons",
                table: "Service");

            migrationBuilder.AddColumn<decimal>(
                name: "Advance",
                table: "Customer",
                type: "decimal(10,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookingDays",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckIn",
                table: "Customer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalPersons",
                table: "Customer",
                type: "int",
                nullable: true);
        }
    }
}
