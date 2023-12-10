using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskApi.DataAcses.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "id", "create", "description", "due", "ststus", "title" },
                values: new object[] { 1, new DateTime(2023, 12, 7, 16, 29, 34, 622, DateTimeKind.Local).AddTicks(528), "Get books fro the School new", new DateTime(2023, 12, 12, 16, 29, 34, 622, DateTimeKind.Local).AddTicks(6548), 0, "Gets book new from SQl" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
