using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class AddUserItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FinishDate",
                table: "TaskItems",
                newName: "FinishedDate");

            migrationBuilder.AddColumn<int>(
                name: "AssigneeId",
                table: "TaskItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserItems", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssigneeId", "CreatedDate", "Description", "FinishedDate", "Title" },
                values: new object[] { null, new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(6787), "Описание 1", new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(6803), "Название 1" });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssigneeId", "CreatedDate", "Description", "FinishedDate", "Title" },
                values: new object[] { null, new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(6805), "Описание 2", new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(6805), "Название 2" });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssigneeId", "CreatedDate", "Description", "FinishedDate", "Title" },
                values: new object[] { null, new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(6807), "Описание 3", new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(6807), "Название 3" });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssigneeId", "CreatedDate", "Description", "FinishedDate", "Title" },
                values: new object[] { null, new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(6808), "Описание 4", new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(6809), "Название 4" });

            migrationBuilder.InsertData(
                table: "UserItems",
                columns: new[] { "Id", "Email", "FullName", "RegisteredDate" },
                values: new object[,]
                {
                    { 1, "user1@example.com", "Пользователь 1", new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(7027) },
                    { 2, "user2@example.com", "Пользователь 2", new DateTime(2024, 11, 20, 15, 55, 15, 905, DateTimeKind.Local).AddTicks(7029) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_AssigneeId",
                table: "TaskItems",
                column: "AssigneeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_UserItems_AssigneeId",
                table: "TaskItems",
                column: "AssigneeId",
                principalTable: "UserItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_UserItems_AssigneeId",
                table: "TaskItems");

            migrationBuilder.DropTable(
                name: "UserItems");

            migrationBuilder.DropIndex(
                name: "IX_TaskItems_AssigneeId",
                table: "TaskItems");

            migrationBuilder.DropColumn(
                name: "AssigneeId",
                table: "TaskItems");

            migrationBuilder.RenameColumn(
                name: "FinishedDate",
                table: "TaskItems",
                newName: "FinishDate");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "FinishDate", "Title" },
                values: new object[] { new DateTime(2024, 11, 19, 16, 9, 15, 758, DateTimeKind.Local).AddTicks(9493), "Описание задачи 1", null, "Задача 1" });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "FinishDate", "Title" },
                values: new object[] { new DateTime(2024, 11, 19, 16, 9, 15, 758, DateTimeKind.Local).AddTicks(9510), "Описание задачи 2", null, "Задача 2" });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "FinishDate", "Title" },
                values: new object[] { new DateTime(2024, 11, 19, 16, 9, 15, 758, DateTimeKind.Local).AddTicks(9512), "Описание задачи 3", null, "Задача 3" });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "FinishDate", "Title" },
                values: new object[] { new DateTime(2024, 11, 19, 16, 9, 15, 758, DateTimeKind.Local).AddTicks(9514), "Описание задачи 4", null, "Задача 4" });
        }
    }
}
