using BusinessTrip.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTrip.Infrastructure.Persistence
{
    public class BusinessTripDbContext : DbContext
    {
        public BusinessTripDbContext(DbContextOptions<BusinessTripDbContext> options) : base(options)
        {
        }


        public DbSet<BusinessTripRequest> BusinessTripRequests { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<TripPurpose> TripPurposes { get; set; }
        public DbSet<TravelService> TravelServices { get; set; }
        public DbSet<TripRequestTravelService> TripRequestTravelServices { get; set; }
        public DbSet<TripAttachment> TripAttachments { get; set; }
        public DbSet<TravelBooking> TravelBookings { get; set; }
        public DbSet<TripApproval>  TripApprovals {get;set;}

    }
}
