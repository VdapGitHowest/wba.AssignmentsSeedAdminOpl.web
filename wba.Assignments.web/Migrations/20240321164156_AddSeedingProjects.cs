using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wba.Assignments.web.Migrations
{
    public partial class AddSeedingProjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Created", "Deleted", "Description", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Redesigning the company website to improve user experience and add new features.", new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Website Redesign", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Launching a new product in the market with extensive marketing campaigns.", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Product Launch", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Implementing a training program for employees to enhance skills and productivity.", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Internal Training Program", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 3, 21, 16, 38, 33, 480, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 3, 21, 16, 38, 33, 480, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 3, 21, 16, 38, 33, 480, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 3, 21, 16, 38, 33, 480, DateTimeKind.Utc).AddTicks(8037));
        }
    }
}
