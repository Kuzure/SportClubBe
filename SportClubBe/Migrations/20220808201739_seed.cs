using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportClubBe.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateDate", "CreateEmail", "IsActive", "LMDate", "LMEmail", "Name" },
                values: new object[] { new Guid("60359a55-3c34-4230-a5b6-6c8afa0f17e5"), new DateTime(2022, 8, 8, 22, 17, 39, 825, DateTimeKind.Local).AddTicks(945), null, true, null, null, "Coach" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateDate", "CreateEmail", "IsActive", "LMDate", "LMEmail", "Name" },
                values: new object[] { new Guid("8be3d024-9f31-41c4-9768-80e2afd5cd0e"), new DateTime(2022, 8, 8, 22, 17, 39, 825, DateTimeKind.Local).AddTicks(906), null, true, null, null, "Competitor" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateDate", "CreateEmail", "IsActive", "LMDate", "LMEmail", "Name" },
                values: new object[] { new Guid("c1310f5a-6187-4fc4-9de1-450eba8707bc"), new DateTime(2022, 8, 8, 22, 17, 39, 825, DateTimeKind.Local).AddTicks(949), null, true, null, null, "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("60359a55-3c34-4230-a5b6-6c8afa0f17e5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8be3d024-9f31-41c4-9768-80e2afd5cd0e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c1310f5a-6187-4fc4-9de1-450eba8707bc"));
        }
    }
}
