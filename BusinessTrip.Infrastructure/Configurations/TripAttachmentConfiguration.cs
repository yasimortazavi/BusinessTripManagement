using BusinessTrip.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BusinessTrip.Infrastructure.Configurations
{
    public class TripAttachmentConfiguration : IEntityTypeConfiguration<TripAttachment>
    {
        public void Configure(EntityTypeBuilder<TripAttachment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.OriginalFileName)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(x  => x.StoredFileName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.StoragePath)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(x => x.ContentType)
                .IsRequired()
                .HasMaxLength (100);


            builder.Property( x => x.FileSize)
                .IsRequired();  



           builder.HasOne(x => x.BusinessTripRequest)
                    .WithMany( x => x.Attachments)  
                    .HasForeignKey(x => x.BusinessTripRequestId)
                    .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
