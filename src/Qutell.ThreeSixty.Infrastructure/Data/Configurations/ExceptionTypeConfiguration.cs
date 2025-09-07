using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Qutell.ThreeSixty.Domain.Entities.Lookups.otherLookups;

namespace Qutell.ThreeSixty.Infrastructure.Data.Configurations
{
    public class ExceptionTypeConfiguration: IEntityTypeConfiguration<ExceptionType>
    {
        public void Configure(EntityTypeBuilder<ExceptionType> builder)
        {
            builder.ToTable("ExceptionTypes");
            builder.ConfigureLookup(et => et.Id,
                new[]
                {
                    new ExceptionType { Id = 1, Name = "System Error" },
                    new ExceptionType { Id = 2, Name = "Application Error" },
                    new ExceptionType { Id = 3, Name = "Network Error" },
                    new ExceptionType { Id = 4, Name = "Database Error" },
                    new ExceptionType { Id = 5, Name = "Unknown Error" }
                });
        }

        
    }
}
