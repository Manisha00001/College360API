using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace College360API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNavigationYaw2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Yaw",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 5,
                column: "Yaw",
                value: 60.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Yaw",
                value: 70.0);

            migrationBuilder.UpdateData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 5,
                column: "Yaw",
                value: 0.0);
        }
    }
}
