using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Qutell.ThreeSixty.Domain.Entities.Lookups.GeneralLookups;

namespace Qutell.ThreeSixty.Infrastructure.Data.Configurations
{
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.ToTable("Gender");
            builder.ConfigureLookup(x => x.Id, new[]
      {
            new Gender { Id = 1, Name = "Male" },
            new Gender { Id = 2, Name = "Female" },
            new Gender { Id = 3, Name = "Other" }
        });
        }
    }
}
