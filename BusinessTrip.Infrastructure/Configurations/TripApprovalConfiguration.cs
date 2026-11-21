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
    public class TripApprovalConfiguration : IEntityTypeConfiguration<TripApproval>
    {
        public void Configure(EntityTypeBuilder<TripApproval> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ApproverId)
                .HasMaxLength(450);

            builder.Property(x => x.Description)
                .HasMaxLength(1000);

            builder.Property(x => x.TripApprovalStatus)
                .IsRequired();

            builder.HasOne(x => x.BusinessTripRequest)
                .WithMany(x => x.TripApprovals)
                .HasForeignKey(x => x.BusinessTripRequestId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
