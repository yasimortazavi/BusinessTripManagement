using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTrip.Domain.Entities
{
    public class TravelService
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
        public decimal BaseCost { get; set; }

        public ICollection<TripRequestTravelService> TripRequestTravelServices
        { get; set; } = new List<TripRequestTravelService>();
    }
}
