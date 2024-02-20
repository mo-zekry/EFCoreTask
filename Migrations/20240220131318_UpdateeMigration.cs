using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTask.Migrations
{
    /// <inheritdoc />
    public partial class UpdateeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "NewTasks");

            migrationBuilder.RenameColumn(
                name: "Deadline",
                table: "NewTasks",
                newName: "Date");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewTasks",
                table: "NewTasks",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewTasks",
                table: "NewTasks");

            migrationBuilder.RenameTable(
                name: "NewTasks",
                newName: "Tasks");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Tasks",
                newName: "Deadline");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "Id");
        }
    }
}
