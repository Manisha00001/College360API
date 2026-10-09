using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace College360API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNavigationYaw4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Yaw",
                value: 90.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Yaw",
                value: 270.0);
        }
    }
}
