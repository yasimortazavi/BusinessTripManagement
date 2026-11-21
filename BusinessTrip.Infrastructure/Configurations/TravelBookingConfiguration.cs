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
    public class TravelBookingConfiguration : IEntityTypeConfiguration<TravelBooking>
    {
        public void Configure(EntityTypeBuilder<TravelBooking> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.BookingReference)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.BookingType)
                .IsRequired();

            builder.Property(x => x.ActualCost)
                .HasPrecision(18, 2);

            builder.Property(x => x.BookingStatus )
                .IsRequired();

            builder.Property( x => x.HotelName)
                .HasMaxLength(150);


            builder.Property(x => x.ProviderName)
                .HasMaxLength(150);

            builder.Property(x => x.Notes )
                .HasMaxLength(1000);

            builder.HasOne(x => x.TripRequestTravelService)
                .WithMany(x => x.TravelBookings)
                .HasForeignKey(x => x.TripRequestTravelServiceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
