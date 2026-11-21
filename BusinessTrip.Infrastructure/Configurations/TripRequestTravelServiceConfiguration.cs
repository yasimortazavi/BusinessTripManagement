using BusinessTrip.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTrip.Infrastructure.Configurations
{
    public class TripRequestTravelServiceConfiguration : IEntityTypeConfiguration<TripRequestTravelService>
    {
        public void Configure(EntityTypeBuilder<TripRequestTravelService> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.SelectedAt)
                .IsRequired();


            builder.HasIndex(
                x => new { 
                    x.TravelServiceId,
                    x.BusinessTripRequestId
                
                }).IsUnique();


            builder.HasOne(x => x.BusinessTripRequest)
                .WithMany(x => x.TripRequestTravelServices)
                .HasForeignKey(x => x.BusinessTripRequestId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(x => x.TravelService)
                .WithMany(x => x.TripRequestTravelServices)
                .HasForeignKey(x => x.TravelServiceId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
