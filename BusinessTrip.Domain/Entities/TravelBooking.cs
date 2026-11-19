using BusinessTrip.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTrip.Domain.Entities
{
    public  class TravelBooking
    {
        public int Id { get; set; }
        public int BusinessTripRequestId { get; set; }
        public string BookingReference { get; set; } = string.Empty;
        public BookingType BookingType { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal ActualCost { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public string? HotelName { get; set; } 
        public string? ProviderName { get; set; } 
        public string? Notes { get; set; } 

        public BusinessTripRequest BusinessTripRequest { get; set; }  = null!;
    }
}
