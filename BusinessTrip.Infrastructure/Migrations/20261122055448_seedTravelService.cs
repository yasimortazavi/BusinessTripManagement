using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusinessTrip.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedTravelService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TravelServices",
                columns: new[] { "Id", "BaseCost", "Description", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, 5000000m, "خدمات حمل‌ونقل هوایی", true, "بلیت هواپیما" },
                    { 2, 2000000m, "خدمات حمل‌ونقل ریلی", true, "بلیت قطار" },
                    { 3, 3000000m, "خدمات اقامت", true, "رزرو هتل" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TravelServices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TravelServices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TravelServices",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
