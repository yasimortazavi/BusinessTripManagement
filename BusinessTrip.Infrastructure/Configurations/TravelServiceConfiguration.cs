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
    public class TravelServiceConfiguration : IEntityTypeConfiguration<TravelService>
    {
        public void Configure(EntityTypeBuilder<TravelService> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.Description)
                .HasMaxLength(500);


            builder.Property(x => x.IsActive)
                .IsRequired();


            builder.Property(x => x.BaseCost)
                .HasPrecision(18,2);





            builder.HasData(

                new TravelService
                {
                    Id = 1,
                    Name = "بلیت هواپیما",
                    Description = "خدمات حمل‌ونقل هوایی",
                    BaseCost = 5000000,
                    IsActive = true,
                },
                new TravelService
                {
                    Id = 2,
                    Name = "بلیت قطار",
                    Description = "خدمات حمل‌ونقل ریلی",
                    BaseCost = 2000000,
                    IsActive = true,
                },
                new TravelService
                {
                    Id = 3,
                    Name = "رزرو هتل",
                    Description = "خدمات اقامت",
                    BaseCost = 3000000,
                    IsActive = true,
                });                
        }
    }
}
