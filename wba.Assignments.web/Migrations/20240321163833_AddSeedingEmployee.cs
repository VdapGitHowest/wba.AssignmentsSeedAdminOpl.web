using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wba.Assignments.web.Migrations
{
    public partial class AddSeedingEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Created", "Deleted", "Department", "Name", "Position" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 21, 16, 38, 33, 480, DateTimeKind.Utc).AddTicks(8031), null, "IT", "Peter Van Damme", "Developer" },
                    { 2, new DateTime(2024, 3, 21, 16, 38, 33, 480, DateTimeKind.Utc).AddTicks(8036), null, "IT", "Kris Meert", "Analyst" },
                    { 3, new DateTime(2024, 3, 21, 16, 38, 33, 480, DateTimeKind.Utc).AddTicks(8036), null, "IT", "Ann Verboost", "AI-specialist" },
                    { 4, new DateTime(2024, 3, 21, 16, 38, 33, 480, DateTimeKind.Utc).AddTicks(8037), null, "IT", "Rudy Minneboom", "DPO" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
