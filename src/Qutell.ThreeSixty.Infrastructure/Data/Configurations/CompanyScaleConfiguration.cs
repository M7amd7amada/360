using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Qutell.ThreeSixty.Domain.Entities.Lookups.CompanyRelatedLookups;

namespace Qutell.ThreeSixty.Infrastructure.Data.Configurations
{
    public class CompanyScaleConfiguration : IEntityTypeConfiguration<CompanyScale>
    {
        public void Configure(EntityTypeBuilder<CompanyScale> builder)
        {
            builder.ToTable("CompanyScales");
            builder.ConfigureLookup(cs => cs.Id,
                new[]
                {
                    new CompanyScale { Id = 1, Name = "Small" },
                    new CompanyScale { Id = 2, Name = "Medium" },
                    new CompanyScale { Id = 3, Name = "Large" }
                });
        }
    }
}
