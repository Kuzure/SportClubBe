using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportClub.Persistance.Migrations
{
    public partial class nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Identity_User_UserId",
                table: "Identity");

            migrationBuilder.DropIndex(
                name: "IX_Identity_UserId",
                table: "Identity");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Identity",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("60359a55-3c34-4230-a5b6-6c8afa0f17e5"),
                column: "CreateDate",
                value: new DateTime(2022, 11, 11, 18, 11, 6, 360, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8be3d024-9f31-41c4-9768-80e2afd5cd0e"),
                column: "CreateDate",
                value: new DateTime(2022, 11, 11, 18, 11, 6, 360, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c1310f5a-6187-4fc4-9de1-450eba8707bc"),
                column: "CreateDate",
                value: new DateTime(2022, 11, 11, 18, 11, 6, 360, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.CreateIndex(
                name: "IX_Identity_UserId",
                table: "Identity",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Identity_User_UserId",
                table: "Identity",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Identity_User_UserId",
                table: "Identity");

            migrationBuilder.DropIndex(
                name: "IX_Identity_UserId",
                table: "Identity");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Identity",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Identity_UserId",
                table: "Identity",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Identity_User_UserId",
                table: "Identity",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
