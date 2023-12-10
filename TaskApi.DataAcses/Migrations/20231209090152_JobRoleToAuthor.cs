using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskApi.DataAcses.Migrations
{
    public partial class JobRoleToAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "jobRole",
                table: "Authors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 1,
                column: "jobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 2,
                column: "jobRole",
                value: "System Engineer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 3,
                column: "jobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 4,
                column: "jobRole",
                value: "QA");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "create", "due" },
                values: new object[] { new DateTime(2023, 12, 9, 14, 31, 52, 25, DateTimeKind.Local).AddTicks(4311), new DateTime(2023, 12, 14, 14, 31, 52, 26, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "create", "due" },
                values: new object[] { new DateTime(2023, 12, 9, 14, 31, 52, 26, DateTimeKind.Local).AddTicks(4450), new DateTime(2023, 12, 13, 14, 31, 52, 26, DateTimeKind.Local).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "create", "due" },
                values: new object[] { new DateTime(2023, 12, 9, 14, 31, 52, 26, DateTimeKind.Local).AddTicks(4464), new DateTime(2023, 12, 12, 14, 31, 52, 26, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "create", "due" },
                values: new object[] { new DateTime(2023, 12, 9, 14, 31, 52, 26, DateTimeKind.Local).AddTicks(4467), new DateTime(2023, 12, 10, 14, 31, 52, 26, DateTimeKind.Local).AddTicks(4468) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "jobRole",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "create", "due" },
                values: new object[] { new DateTime(2023, 12, 8, 14, 30, 17, 510, DateTimeKind.Local).AddTicks(8011), new DateTime(2023, 12, 13, 14, 30, 17, 511, DateTimeKind.Local).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "create", "due" },
                values: new object[] { new DateTime(2023, 12, 8, 14, 30, 17, 511, DateTimeKind.Local).AddTicks(4666), new DateTime(2023, 12, 12, 14, 30, 17, 511, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "create", "due" },
                values: new object[] { new DateTime(2023, 12, 8, 14, 30, 17, 511, DateTimeKind.Local).AddTicks(4673), new DateTime(2023, 12, 11, 14, 30, 17, 511, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "create", "due" },
                values: new object[] { new DateTime(2023, 12, 8, 14, 30, 17, 511, DateTimeKind.Local).AddTicks(4676), new DateTime(2023, 12, 9, 14, 30, 17, 511, DateTimeKind.Local).AddTicks(4676) });
        }
    }
}
