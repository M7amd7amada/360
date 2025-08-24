using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Qutell.ThreeSixty.Domain.Entities.Lookups.CompanyRelatedLookups;

namespace Qutell.ThreeSixty.Infrastructure.Data.Configurations
{
    public class CompanyTypeConfiguration : IEntityTypeConfiguration<CompanyType>
    {
        public void Configure(EntityTypeBuilder<CompanyType> builder)
        {
            builder.ToTable("CompanyTypes");
            builder.ConfigureLookup(ct => ct.Id,
                new[]
                {
                    new CompanyType { Id = 1, Name = "Private" },
                    new CompanyType { Id = 2, Name = "Public" },
                    new CompanyType { Id = 3, Name = "Government" },
                    new CompanyType { Id = 4, Name = "Non-Profit" }
                });
        }
    }
}
