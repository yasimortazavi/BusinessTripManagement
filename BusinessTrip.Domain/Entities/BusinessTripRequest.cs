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
}