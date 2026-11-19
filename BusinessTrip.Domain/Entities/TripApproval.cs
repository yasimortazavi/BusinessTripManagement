using BusinessTrip.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTrip.Domain.Entities
{
    public class TripApproval
    {
        public int Id { get; set; }
        public int BusinessTripRequestId { get; set; }
        public BusinessTripRequest BusinessTripRequest { get; set; } = null!;
        public string? ApproverId { get; set; } 
        public string? Description { get; set; }    
        public TripApprovalStatus TripApprovalStatus { get; set; }
        public DateTime? DecisionDate { get; set; } 
    }
}
