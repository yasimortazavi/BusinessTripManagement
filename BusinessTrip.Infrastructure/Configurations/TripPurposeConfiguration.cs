using BusinessTrip.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessTrip.Infrastructure.Configurations
{
    public class TripPurposeConfiguration : IEntityTypeConfiguration<TripPurpose>
    {
        public void Configure(EntityTypeBuilder<TripPurpose> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.Description)
                .HasMaxLength(500);

            builder.Property(x => x.IsActive)
                .IsRequired();
        }
    }
}
