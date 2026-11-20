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
    public class BusinessTripRequestConfiguration : IEntityTypeConfiguration<BusinessTripRequest>
    {
        public void Configure(EntityTypeBuilder<BusinessTripRequest> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TrackingCode)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(x => x.TrackingCode)
                .IsUnique();


            builder.Property(x => x.RequesterId)
                .IsRequired()
                .HasMaxLength(450);
            builder.Property(x => x.Description)
                 .IsRequired()
                 .HasMaxLength(2000);

            builder.Property(x => x.StartDate)
                .IsRequired();

            builder.Property(x => x.EndDate)
                .IsRequired();

            builder.Property(x => x.EstimatedBudget)
                 .HasPrecision(18, 2);
      

            builder.Property(x => x.BusinessTripStatus)
                .IsRequired();

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.AdditionalNotes)
                .HasMaxLength(1000);

            builder.HasOne(x => x.Destination)
                .WithMany(x => x.BusinessTripRequests)
                .HasForeignKey(x => x.DestinationId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(x => x.TripPurpose)
                .WithMany(x => x.BusinessTripRequests)
                .HasForeignKey(x => x.TripPurposeId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}

