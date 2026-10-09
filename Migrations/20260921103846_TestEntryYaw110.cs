using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace College360API.Migrations
{
    /// <inheritdoc />
    public partial class TestEntryYaw110 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 7,
                column: "EntryYaw",
                value: 60.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 7,
                column: "EntryYaw",
                value: 0.0);
        }
    }
}
