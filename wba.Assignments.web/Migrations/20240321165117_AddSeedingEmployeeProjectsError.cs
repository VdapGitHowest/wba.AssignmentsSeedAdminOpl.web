using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wba.Assignments.web.Migrations
{
    public partial class AddSeedingEmployeeProjectsError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "AssignedEmployeesId", "AssignedProjectsId" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 3, 21, 16, 51, 17, 134, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 3, 21, 16, 51, 17, 134, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 3, 21, 16, 51, 17, 134, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 3, 21, 16, 51, 17, 134, DateTimeKind.Utc).AddTicks(4080));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "AssignedEmployeesId", "AssignedProjectsId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 3, 21, 16, 50, 11, 753, DateTimeKind.Utc).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 3, 21, 16, 50, 11, 753, DateTimeKind.Utc).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 3, 21, 16, 50, 11, 753, DateTimeKind.Utc).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 3, 21, 16, 50, 11, 753, DateTimeKind.Utc).AddTicks(320));
        }
    }
}
