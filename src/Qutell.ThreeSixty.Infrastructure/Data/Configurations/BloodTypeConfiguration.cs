using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Qutell.ThreeSixty.Domain.Entities.Lookups.GeneralLookups;

namespace Qutell.ThreeSixty.Infrastructure.Data.Configurations
{
    public class BloodTypeConfiguration : IEntityTypeConfiguration<BloodType>
    {
        public void Configure(EntityTypeBuilder<BloodType> builder)
        {
            builder.ToTable("BloodTypes");
            builder.ConfigureLookup(x => x.Id,
               new[]
                {
                    new BloodType { Id = 1, Name = "A+" },
                    new BloodType { Id = 2, Name = "A-" },
                    new BloodType { Id = 3, Name = "B+" },
                    new BloodType { Id = 4, Name = "B-" },
                    new BloodType { Id = 5, Name = "AB+" },
                    new BloodType { Id = 6, Name = "AB-" },
                    new BloodType { Id = 7, Name = "O+" },
                    new BloodType { Id = 8, Name = "O-" }
                });
        }

      
    }
}
