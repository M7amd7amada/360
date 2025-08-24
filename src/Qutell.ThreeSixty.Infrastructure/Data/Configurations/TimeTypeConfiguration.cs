
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Qutell.ThreeSixty.Domain.Entities.Lookups.TimeRelatedLookups;

namespace Qutell.ThreeSixty.Infrastructure.Data.Configurations
{
    public class TimeTypeConfiguration : IEntityTypeConfiguration<TimeType>
    {
        public void Configure(EntityTypeBuilder<TimeType> builder)
        {
            builder.ToTable("TimeTypes");
            builder.ConfigureLookup(tt => tt.Id,
                 new[]
                 {
                    new TimeType { Id = 1, Name = "Working Hours" },
                    new TimeType { Id = 2, Name = "Overtime" },
                    new TimeType { Id = 3, Name = "Leave" },
                    new TimeType { Id = 4, Name = "Holiday" },
                    new TimeType { Id = 5, Name = "Sick Leave" }
                 });
        }
    }
}
