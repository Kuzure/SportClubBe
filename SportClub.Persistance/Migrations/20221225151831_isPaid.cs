using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportClub.Persistance.Migrations
{
    public partial class isPaid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LMEmail",
                table: "User",
                newName: "LmEmail");

            migrationBuilder.RenameColumn(
                name: "LMDate",
                table: "User",
                newName: "LmDate");

            migrationBuilder.RenameColumn(
                name: "LMEmail",
                table: "Role",
                newName: "LmEmail");

            migrationBuilder.RenameColumn(
                name: "LMDate",
                table: "Role",
                newName: "LmDate");

            migrationBuilder.RenameColumn(
                name: "LMEmail",
                table: "Identity",
                newName: "LmEmail");

            migrationBuilder.RenameColumn(
                name: "LMDate",
                table: "Identity",
                newName: "LmDate");

            migrationBuilder.RenameColumn(
                name: "LMEmail",
                table: "GroupExercise",
                newName: "LmEmail");

            migrationBuilder.RenameColumn(
                name: "LMDate",
                table: "GroupExercise",
                newName: "LmDate");

            migrationBuilder.RenameColumn(
                name: "LMEmail",
                table: "Group",
                newName: "LmEmail");

            migrationBuilder.RenameColumn(
                name: "LMDate",
                table: "Group",
                newName: "LmDate");

            migrationBuilder.RenameColumn(
                name: "LMEmail",
                table: "File",
                newName: "LmEmail");

            migrationBuilder.RenameColumn(
                name: "LMDate",
                table: "File",
                newName: "LmDate");

            migrationBuilder.RenameColumn(
                name: "LMEmail",
                table: "Exercise",
                newName: "LmEmail");

            migrationBuilder.RenameColumn(
                name: "LMDate",
                table: "Exercise",
                newName: "LmDate");

            migrationBuilder.RenameColumn(
                name: "LMEmail",
                table: "Competitor",
                newName: "LmEmail");

            migrationBuilder.RenameColumn(
                name: "LMDate",
                table: "Competitor",
                newName: "LmDate");

            migrationBuilder.RenameColumn(
                name: "Is_Paid",
                table: "Competitor",
                newName: "IsPaid");

            migrationBuilder.RenameColumn(
                name: "LMEmail",
                table: "CoachGroup",
                newName: "LmEmail");

            migrationBuilder.RenameColumn(
                name: "LMDate",
                table: "CoachGroup",
                newName: "LmDate");

            migrationBuilder.RenameColumn(
                name: "LMEmail",
                table: "Coach",
                newName: "LmEmail");

            migrationBuilder.RenameColumn(
                name: "LMDate",
                table: "Coach",
                newName: "LmDate");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Group",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LmEmail",
                table: "User",
                newName: "LMEmail");

            migrationBuilder.RenameColumn(
                name: "LmDate",
                table: "User",
                newName: "LMDate");

            migrationBuilder.RenameColumn(
                name: "LmEmail",
                table: "Role",
                newName: "LMEmail");

            migrationBuilder.RenameColumn(
                name: "LmDate",
                table: "Role",
                newName: "LMDate");

            migrationBuilder.RenameColumn(
                name: "LmEmail",
                table: "Identity",
                newName: "LMEmail");

            migrationBuilder.RenameColumn(
                name: "LmDate",
                table: "Identity",
                newName: "LMDate");

            migrationBuilder.RenameColumn(
                name: "LmEmail",
                table: "GroupExercise",
                newName: "LMEmail");

            migrationBuilder.RenameColumn(
                name: "LmDate",
                table: "GroupExercise",
                newName: "LMDate");

            migrationBuilder.RenameColumn(
                name: "LmEmail",
                table: "Group",
                newName: "LMEmail");

            migrationBuilder.RenameColumn(
                name: "LmDate",
                table: "Group",
                newName: "LMDate");

            migrationBuilder.RenameColumn(
                name: "LmEmail",
                table: "File",
                newName: "LMEmail");

            migrationBuilder.RenameColumn(
                name: "LmDate",
                table: "File",
                newName: "LMDate");

            migrationBuilder.RenameColumn(
                name: "LmEmail",
                table: "Exercise",
                newName: "LMEmail");

            migrationBuilder.RenameColumn(
                name: "LmDate",
                table: "Exercise",
                newName: "LMDate");

            migrationBuilder.RenameColumn(
                name: "LmEmail",
                table: "Competitor",
                newName: "LMEmail");

            migrationBuilder.RenameColumn(
                name: "LmDate",
                table: "Competitor",
                newName: "LMDate");

            migrationBuilder.RenameColumn(
                name: "IsPaid",
                table: "Competitor",
                newName: "Is_Paid");

            migrationBuilder.RenameColumn(
                name: "LmEmail",
                table: "CoachGroup",
                newName: "LMEmail");

            migrationBuilder.RenameColumn(
                name: "LmDate",
                table: "CoachGroup",
                newName: "LMDate");

            migrationBuilder.RenameColumn(
                name: "LmEmail",
                table: "Coach",
                newName: "LMEmail");

            migrationBuilder.RenameColumn(
                name: "LmDate",
                table: "Coach",
                newName: "LMDate");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Group",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
