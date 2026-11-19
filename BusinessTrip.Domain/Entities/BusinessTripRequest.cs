using BusinessTrip.Domain.Enums;

namespace BusinessTrip.Domain.Entities;

public class BusinessTripRequest
{
    public int Id { get; set; }

    public string TrackingCode { get; set; } = string.Empty;

    public string RequesterId { get; set; } = string.Empty;

    public int DestinationId { get; set; }

    public Destination Destination { get; set; } = null!;

    public int TripPurposeId { get; set; }

    public TripPurpose TripPurpose { get; set; } = null!;

    public string Description { get; set; } = string.Empty;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal EstimatedBudget { get; set; }

    public BusinessTripStatus BusinessTripStatus { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public string? AdditionalNotes { get; set; }


    public ICollection<TripRequestTravelService> TripRequestTravelServices
    { get; set; } = new List<TripRequestTravelService>();

    public ICollection<TripAttachment> Attachments
    { get; set; } = new List<TripAttachment>();


    public ICollection<TripApproval> TripApprovals
    { get; set; } = new List<TripApproval>();
}