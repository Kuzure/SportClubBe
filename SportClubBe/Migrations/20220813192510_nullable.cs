using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportClub.Api.Migrations
{
    public partial class nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("60359a55-3c34-4230-a5b6-6c8afa0f17e5"),
                column: "CreateDate",
                value: new DateTime(2022, 8, 13, 21, 25, 10, 651, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8be3d024-9f31-41c4-9768-80e2afd5cd0e"),
                column: "CreateDate",
                value: new DateTime(2022, 8, 13, 21, 25, 10, 651, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c1310f5a-6187-4fc4-9de1-450eba8707bc"),
                column: "CreateDate",
                value: new DateTime(2022, 8, 13, 21, 25, 10, 651, DateTimeKind.Local).AddTicks(2007));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("60359a55-3c34-4230-a5b6-6c8afa0f17e5"),
                column: "CreateDate",
                value: new DateTime(2022, 8, 13, 21, 20, 8, 896, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8be3d024-9f31-41c4-9768-80e2afd5cd0e"),
                column: "CreateDate",
                value: new DateTime(2022, 8, 13, 21, 20, 8, 896, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c1310f5a-6187-4fc4-9de1-450eba8707bc"),
                column: "CreateDate",
                value: new DateTime(2022, 8, 13, 21, 20, 8, 896, DateTimeKind.Local).AddTicks(1805));
        }
    }
}
