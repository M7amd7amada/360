using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Qutell.ThreeSixty.Domain.Entities.Lookups.TimeRelatedLookups;

namespace Qutell.ThreeSixty.Infrastructure.Data.Configurations
{
    public class ShiftTypeConfiguration : IEntityTypeConfiguration<ShiftType>
    {
        public void Configure(EntityTypeBuilder<ShiftType> builder)
        {
            builder.ToTable("ShiftTypes");
            builder.ConfigureLookup(st => st.Id,
                new[]
                {
                    new ShiftType { Id = 1, Name = "Morning" },
                    new ShiftType { Id = 2, Name = "Afternoon" },
                    new ShiftType { Id = 3, Name = "Night" },
                    new ShiftType { Id = 4, Name = "Flexible" }
                });
        }
    }
}
