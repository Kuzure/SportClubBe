using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportClub.Persistance.Migrations
{
    public partial class user_id_nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("60359a55-3c34-4230-a5b6-6c8afa0f17e5"),
                column: "CreateDate",
                value: new DateTime(2022, 11, 11, 17, 57, 25, 695, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8be3d024-9f31-41c4-9768-80e2afd5cd0e"),
                column: "CreateDate",
                value: new DateTime(2022, 11, 11, 17, 57, 25, 695, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c1310f5a-6187-4fc4-9de1-450eba8707bc"),
                column: "CreateDate",
                value: new DateTime(2022, 11, 11, 17, 57, 25, 695, DateTimeKind.Local).AddTicks(3030));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("60359a55-3c34-4230-a5b6-6c8afa0f17e5"),
                column: "CreateDate",
                value: new DateTime(2022, 8, 15, 12, 2, 16, 597, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8be3d024-9f31-41c4-9768-80e2afd5cd0e"),
                column: "CreateDate",
                value: new DateTime(2022, 8, 15, 12, 2, 16, 597, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c1310f5a-6187-4fc4-9de1-450eba8707bc"),
                column: "CreateDate",
                value: new DateTime(2022, 8, 15, 12, 2, 16, 597, DateTimeKind.Local).AddTicks(6519));
        }
    }
}
