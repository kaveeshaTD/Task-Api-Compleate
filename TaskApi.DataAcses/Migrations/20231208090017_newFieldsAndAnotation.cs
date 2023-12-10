using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskApi.DataAcses.Migrations
{
    public partial class newFieldsAndAnotation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "Todos",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "Todos",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddrssNo",
                table: "Authors",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Authors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "street",
                table: "Authors",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "AddrssNo", "city", "street" },
                values: new object[] { "50", "Colombo 1", "street 1" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "AddrssNo", "city", "street" },
                values: new object[] { "60", "Colombo 2", "street 2" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "AddrssNo", "city", "street" },
                values: new object[] { "70", "Colombo 3", "street 3" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "AddrssNo", "city", "street" },
                values: new object[] { "80", "Colombo 4", "street 4" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddrssNo",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "street",
                table: "Authors");

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "create", "due" },
                values: new object[] { new DateTime(2023, 12, 7, 21, 31, 24, 718, DateTimeKind.Local).AddTicks(4641), new DateTime(2023, 12, 12, 21, 31, 24, 719, DateTimeKind.Local).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "create", "due" },
                values: new object[] { new DateTime(2023, 12, 7, 21, 31, 24, 719, DateTimeKind.Local).AddTicks(1545), new DateTime(2023, 12, 11, 21, 31, 24, 719, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "create", "due" },
                values: new object[] { new DateTime(2023, 12, 7, 21, 31, 24, 719, DateTimeKind.Local).AddTicks(1552), new DateTime(2023, 12, 10, 21, 31, 24, 719, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "create", "due" },
                values: new object[] { new DateTime(2023, 12, 7, 21, 31, 24, 719, DateTimeKind.Local).AddTicks(1555), new DateTime(2023, 12, 8, 21, 31, 24, 719, DateTimeKind.Local).AddTicks(1555) });
        }
    }
}
