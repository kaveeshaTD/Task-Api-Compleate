using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskApi.DataAcses.Migrations
{
    public partial class AuthorAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Authorid",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "id", "FullName" },
                values: new object[,]
                {
                    { 1, "kaveesha" },
                    { 2, "Thathsara" },
                    { 3, "Sandaru" },
                    { 4, "Nimesh" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Authorid", "create", "due" },
                values: new object[] { 1, new DateTime(2023, 12, 7, 21, 31, 24, 718, DateTimeKind.Local).AddTicks(4641), new DateTime(2023, 12, 12, 21, 31, 24, 719, DateTimeKind.Local).AddTicks(989) });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "id", "Authorid", "create", "description", "due", "ststus", "title" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2023, 12, 7, 21, 31, 24, 719, DateTimeKind.Local).AddTicks(1545), "Get spare arts for vehichel new", new DateTime(2023, 12, 11, 21, 31, 24, 719, DateTimeKind.Local).AddTicks(1548), 0, "Get car parts new from Sql" },
                    { 3, 2, new DateTime(2023, 12, 7, 21, 31, 24, 719, DateTimeKind.Local).AddTicks(1552), "Get foods for the week new", new DateTime(2023, 12, 10, 21, 31, 24, 719, DateTimeKind.Local).AddTicks(1553), 0, "Get Food New from Sql" },
                    { 4, 3, new DateTime(2023, 12, 7, 21, 31, 24, 719, DateTimeKind.Local).AddTicks(1555), "Get medicine Hosptiale new", new DateTime(2023, 12, 8, 21, 31, 24, 719, DateTimeKind.Local).AddTicks(1555), 0, "Get Medicine new from Sql" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_Authorid",
                table: "Todos",
                column: "Authorid");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_Authorid",
                table: "Todos",
                column: "Authorid",
                principalTable: "Authors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_Authorid",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_Authorid",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Authorid",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "create", "due" },
                values: new object[] { new DateTime(2023, 12, 7, 16, 29, 34, 622, DateTimeKind.Local).AddTicks(528), new DateTime(2023, 12, 12, 16, 29, 34, 622, DateTimeKind.Local).AddTicks(6548) });
        }
    }
}
