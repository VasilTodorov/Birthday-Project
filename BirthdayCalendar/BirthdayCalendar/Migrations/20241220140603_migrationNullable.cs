using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BirthdayCalendar.Migrations
{
    /// <inheritdoc />
    public partial class migrationNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_BirthdayEventId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "BirthdayEventId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BirthdayEventId",
                table: "Users",
                column: "BirthdayEventId",
                unique: true,
                filter: "[BirthdayEventId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_BirthdayEventId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "BirthdayEventId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_BirthdayEventId",
                table: "Users",
                column: "BirthdayEventId",
                unique: true);
        }
    }
}
