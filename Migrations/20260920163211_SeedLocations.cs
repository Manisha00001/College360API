using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace College360API.Migrations
{
    /// <inheritdoc />
    public partial class SeedLocations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Description", "Floor", "ImagePath", "Name" },
                values: new object[,]
                {
                    { 1, "College main entrance", 1, "assets/img1.jpg", "Main Entrance" },
                    { 2, "College reception area", 1, "assets/img2.jpg", "Reception" },
                    { 3, "Main corridor", 1, "assets/img3.jpg", "Corridor" },
                    { 4, "Department office area", 1, "assets/img4.jpg", "Department Office" },
                    { 5, "Staircase area", 1, "assets/img5.jpg", "Staircase" },
                    { 6, "", 1, "assets/img6.jpg", "Location 6" },
                    { 7, "", 1, "assets/img7.jpg", "Location 7" },
                    { 8, "", 1, "assets/img8.jpg", "Location 8" },
                    { 9, "", 1, "assets/img9.jpg", "Location 9" },
                    { 10, "", 1, "assets/img10.jpg", "Location 10" },
                    { 11, "", 1, "assets/img11.jpg", "Location 11" },
                    { 12, "", 1, "assets/img12.jpg", "Location 12" },
                    { 13, "", 1, "assets/img13.jpg", "Location 13" },
                    { 14, "", 1, "assets/img14.jpg", "Location 14" },
                    { 15, "", 1, "assets/img15.jpg", "Location 15" },
                    { 16, "", 1, "assets/img16.jpg", "Location 16" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
