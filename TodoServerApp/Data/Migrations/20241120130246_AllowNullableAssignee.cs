using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class AllowNullableAssignee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 2, 45, 406, DateTimeKind.Local).AddTicks(8376), new DateTime(2024, 11, 20, 16, 2, 45, 406, DateTimeKind.Local).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 2, 45, 406, DateTimeKind.Local).AddTicks(8394), new DateTime(2024, 11, 20, 16, 2, 45, 406, DateTimeKind.Local).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 2, 45, 406, DateTimeKind.Local).AddTicks(8396), new DateTime(2024, 11, 20, 16, 2, 45, 406, DateTimeKind.Local).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 2, 45, 406, DateTimeKind.Local).AddTicks(8398), new DateTime(2024, 11, 20, 16, 2, 45, 406, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "UserItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisteredDate",
                value: new DateTime(2024, 11, 20, 16, 2, 45, 406, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "UserItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisteredDate",
                value: new DateTime(2024, 11, 20, 16, 2, 45, 406, DateTimeKind.Local).AddTicks(8710));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(6787), new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(6805), new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(6807), new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FinishedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(6808), new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "UserItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisteredDate",
                value: new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "UserItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisteredDate",
                value: new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(7029));
        }
    }
}
