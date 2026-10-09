using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace College360API.Migrations
{
    /// <inheritdoc />
    public partial class AddEntryYaw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "EntryYaw",
                table: "Navigations",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EntryYaw", "Yaw" },
                values: new object[] { 270.0, 90.0 });

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EntryYaw", "Yaw" },
                values: new object[] { 90.0, 270.0 });

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 3,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 4,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 5,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 6,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 7,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 8,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 9,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 10,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 11,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 12,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 13,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 14,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 15,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 16,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 17,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 18,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 19,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 20,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 21,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 22,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 23,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 24,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 25,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 26,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 27,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 28,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 29,
                column: "EntryYaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 30,
                column: "EntryYaw",
                value: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EntryYaw",
                table: "Navigations");

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Yaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Yaw",
                value: 180.0);
        }
    }
}
