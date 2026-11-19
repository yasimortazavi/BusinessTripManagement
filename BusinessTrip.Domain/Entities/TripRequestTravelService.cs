using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTrip.Domain.Entities;

public class TripRequestTravelService
{
    public int Id { get; set; }
    public int BusinessTripRequestId { get; set; }

    public BusinessTripRequest BusinessTripRequest { get; set; } = null!;

    public int TravelServiceId { get; set; }

    public TravelService TravelService { get; set; } = null!;

    public DateTime SelectedAt { get; set; } = DateTime.UtcNow;
}