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
    public class DestinationConfiguration : IEntityTypeConfiguration<Destination>
    {
        public void Configure(EntityTypeBuilder<Destination> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(150);


            builder.Property(x => x.Description)
                .HasMaxLength(500);


            builder.Property(x => x.IsActive)
                .IsRequired();

      


            builder.HasData(
                    new Destination { 
                        Id = 1,
                        Name = "تهران",
                        Description = "پایتخت ایران",
                        IsActive  = true

                    },

                    new Destination { 
                        Id = 2,
                        Name = "اصفهان",
                        Description = "مرکز استان اصفهان",
                        IsActive = true

                    },

                    new Destination
                    {
                        Id = 3,
                        Name = "مشهد",
                        Description = "مرکز استان خراسان رضوی",
                        IsActive = true

                    }
                );
        }
    }
}
