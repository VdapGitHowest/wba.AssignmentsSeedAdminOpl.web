using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wba.Assignments.web.Migrations
{
    public partial class AddSeedingEmployeeProjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "AssignedEmployeesId", "AssignedProjectsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 3, 2 },
                    { 4, 1 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "AssignedEmployeesId", "AssignedProjectsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "AssignedEmployeesId", "AssignedProjectsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "AssignedEmployeesId", "AssignedProjectsId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "AssignedEmployeesId", "AssignedProjectsId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 3, 21, 16, 41, 55, 936, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 3, 21, 16, 41, 55, 936, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 3, 21, 16, 41, 55, 936, DateTimeKind.Utc).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 3, 21, 16, 41, 55, 936, DateTimeKind.Utc).AddTicks(4201));
        }
    }
}
