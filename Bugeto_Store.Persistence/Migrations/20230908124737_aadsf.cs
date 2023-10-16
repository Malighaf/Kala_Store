using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bugeto_Store.Persistence.Migrations
{
    public partial class aadsf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 9, 8, 16, 17, 37, 374, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 9, 8, 16, 17, 37, 376, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 9, 8, 16, 17, 37, 376, DateTimeKind.Local).AddTicks(3959));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2020, 8, 16, 12, 52, 49, 673, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2020, 8, 16, 12, 52, 49, 679, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2020, 8, 16, 12, 52, 49, 679, DateTimeKind.Local).AddTicks(1089));
        }
    }
}
