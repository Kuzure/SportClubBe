using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportClub.Persistance.Migrations
{
    public partial class repetitions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Repetitions",
                table: "Exercise",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("60359a55-3c34-4230-a5b6-6c8afa0f17e5"),
                column: "CreateDate",
                value: new DateTime(2023, 1, 3, 16, 27, 38, 708, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8be3d024-9f31-41c4-9768-80e2afd5cd0e"),
                column: "CreateDate",
                value: new DateTime(2023, 1, 3, 16, 27, 38, 708, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c1310f5a-6187-4fc4-9de1-450eba8707bc"),
                column: "CreateDate",
                value: new DateTime(2023, 1, 3, 16, 27, 38, 708, DateTimeKind.Local).AddTicks(6748));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Repetitions",
                table: "Exercise");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("60359a55-3c34-4230-a5b6-6c8afa0f17e5"),
                column: "CreateDate",
                value: new DateTime(2022, 12, 25, 16, 18, 31, 401, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8be3d024-9f31-41c4-9768-80e2afd5cd0e"),
                column: "CreateDate",
                value: new DateTime(2022, 12, 25, 16, 18, 31, 401, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c1310f5a-6187-4fc4-9de1-450eba8707bc"),
                column: "CreateDate",
                value: new DateTime(2022, 12, 25, 16, 18, 31, 401, DateTimeKind.Local).AddTicks(7272));
        }
    }
}
