using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class JobRoleFieldAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Authors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobRole",
                value: "System Engineer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobRole",
                value: "QA");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 6, 12, 22, 11, 41, 566, DateTimeKind.Local).AddTicks(1810), new DateTime(2023, 6, 17, 22, 11, 41, 566, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 6, 12, 22, 11, 41, 566, DateTimeKind.Local).AddTicks(1832), new DateTime(2023, 6, 17, 22, 11, 41, 566, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 6, 12, 22, 11, 41, 566, DateTimeKind.Local).AddTicks(1837), new DateTime(2023, 6, 17, 22, 11, 41, 566, DateTimeKind.Local).AddTicks(1838) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 6, 10, 22, 25, 15, 60, DateTimeKind.Local).AddTicks(8144), new DateTime(2023, 6, 15, 22, 25, 15, 60, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 6, 10, 22, 25, 15, 60, DateTimeKind.Local).AddTicks(8172), new DateTime(2023, 6, 15, 22, 25, 15, 60, DateTimeKind.Local).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 6, 10, 22, 25, 15, 60, DateTimeKind.Local).AddTicks(8176), new DateTime(2023, 6, 15, 22, 25, 15, 60, DateTimeKind.Local).AddTicks(8177) });
        }
    }
}
