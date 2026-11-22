using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessTrip.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TravelServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BaseCost = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TripPurposes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripPurposes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessTripRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrackingCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RequesterId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: false),
                    TripPurposeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstimatedBudget = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    BusinessTripStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdditionalNotes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessTripRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessTripRequests_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessTripRequests_TripPurposes_TripPurposeId",
                        column: x => x.TripPurposeId,
                        principalTable: "TripPurposes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TripApprovals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessTripRequestId = table.Column<int>(type: "int", nullable: false),
                    ApproverId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    TripApprovalStatus = table.Column<int>(type: "int", nullable: false),
                    DecisionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripApprovals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripApprovals_BusinessTripRequests_BusinessTripRequestId",
                        column: x => x.BusinessTripRequestId,
                        principalTable: "BusinessTripRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TripAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OriginalFileName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    StoredFileName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StoragePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    BusinessTripRequestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripAttachments_BusinessTripRequests_BusinessTripRequestId",
                        column: x => x.BusinessTripRequestId,
                        principalTable: "BusinessTripRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TripRequestTravelServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessTripRequestId = table.Column<int>(type: "int", nullable: false),
                    TravelServiceId = table.Column<int>(type: "int", nullable: false),
                    SelectedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripRequestTravelServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripRequestTravelServices_BusinessTripRequests_BusinessTripRequestId",
                        column: x => x.BusinessTripRequestId,
                        principalTable: "BusinessTripRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripRequestTravelServices_TravelServices_TravelServiceId",
                        column: x => x.TravelServiceId,
                        principalTable: "TravelServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TravelBookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingReference = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BookingType = table.Column<int>(type: "int", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualCost = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    BookingStatus = table.Column<int>(type: "int", nullable: false),
                    HotelName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ProviderName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    TripRequestTravelServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelBookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelBookings_TripRequestTravelServices_TripRequestTravelServiceId",
                        column: x => x.TripRequestTravelServiceId,
                        principalTable: "TripRequestTravelServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTripRequests_DestinationId",
                table: "BusinessTripRequests",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTripRequests_TrackingCode",
                table: "BusinessTripRequests",
                column: "TrackingCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTripRequests_TripPurposeId",
                table: "BusinessTripRequests",
                column: "TripPurposeId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelBookings_TripRequestTravelServiceId",
                table: "TravelBookings",
                column: "TripRequestTravelServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_TripApprovals_BusinessTripRequestId",
                table: "TripApprovals",
                column: "BusinessTripRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_TripAttachments_BusinessTripRequestId",
                table: "TripAttachments",
                column: "BusinessTripRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_TripRequestTravelServices_BusinessTripRequestId",
                table: "TripRequestTravelServices",
                column: "BusinessTripRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_TripRequestTravelServices_TravelServiceId_BusinessTripRequestId",
                table: "TripRequestTravelServices",
                columns: new[] { "TravelServiceId", "BusinessTripRequestId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TravelBookings");

            migrationBuilder.DropTable(
                name: "TripApprovals");

            migrationBuilder.DropTable(
                name: "TripAttachments");

            migrationBuilder.DropTable(
                name: "TripRequestTravelServices");

            migrationBuilder.DropTable(
                name: "BusinessTripRequests");

            migrationBuilder.DropTable(
                name: "TravelServices");

            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropTable(
                name: "TripPurposes");
        }
    }
}
