using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusinessTrip.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedTripPurpose : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TripPurposes",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, "انجام امور محوله سازمانی", true, "مأموریت کاری" },
                    { 2, "حضور در جلسات سازمانی", true, "شرکت در جلسه" },
                    { 3, "شرکت در دوره‌های آموزشی", true, "آموزش" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TripPurposes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TripPurposes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TripPurposes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
