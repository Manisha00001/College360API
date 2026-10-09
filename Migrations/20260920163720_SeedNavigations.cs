using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace College360API.Migrations
{
    /// <inheritdoc />
    public partial class SeedNavigations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Navigations",
                columns: new[] { "Id", "Direction", "FromLocationId", "Pitch", "ToLocationId", "Yaw" },
                values: new object[,]
                {
                    { 1, "Forward", 1, 0.0, 2, 0.0 },
                    { 2, "Backward", 2, 0.0, 1, 180.0 },
                    { 3, "Forward", 2, 0.0, 3, 0.0 },
                    { 4, "Backward", 3, 0.0, 2, 180.0 },
                    { 5, "Forward", 3, 0.0, 4, 0.0 },
                    { 6, "Backward", 4, 0.0, 3, 180.0 },
                    { 7, "Forward", 4, 0.0, 5, 0.0 },
                    { 8, "Backward", 5, 0.0, 4, 180.0 },
                    { 9, "Forward", 5, 0.0, 6, 0.0 },
                    { 10, "Backward", 6, 0.0, 5, 180.0 },
                    { 11, "Forward", 6, 0.0, 7, 0.0 },
                    { 12, "Backward", 7, 0.0, 6, 180.0 },
                    { 13, "Forward", 7, 0.0, 8, 0.0 },
                    { 14, "Backward", 8, 0.0, 7, 180.0 },
                    { 15, "Forward", 8, 0.0, 9, 0.0 },
                    { 16, "Backward", 9, 0.0, 8, 180.0 },
                    { 17, "Forward", 9, 0.0, 10, 0.0 },
                    { 18, "Backward", 10, 0.0, 9, 180.0 },
                    { 19, "Forward", 10, 0.0, 11, 0.0 },
                    { 20, "Backward", 11, 0.0, 10, 180.0 },
                    { 21, "Forward", 11, 0.0, 12, 0.0 },
                    { 22, "Backward", 12, 0.0, 11, 180.0 },
                    { 23, "Forward", 12, 0.0, 13, 0.0 },
                    { 24, "Backward", 13, 0.0, 12, 180.0 },
                    { 25, "Forward", 13, 0.0, 14, 0.0 },
                    { 26, "Backward", 14, 0.0, 13, 180.0 },
                    { 27, "Forward", 14, 0.0, 15, 0.0 },
                    { 28, "Backward", 15, 0.0, 14, 180.0 },
                    { 29, "Forward", 15, 0.0, 16, 0.0 },
                    { 30, "Backward", 16, 0.0, 15, 180.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Navigations",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
