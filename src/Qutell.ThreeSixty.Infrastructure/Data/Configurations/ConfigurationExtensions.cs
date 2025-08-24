using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Qutell.ThreeSixty.Domain.Entities.Lookups;

namespace Qutell.ThreeSixty.Infrastructure.Data.Configurations
{
    public static class ConfigurationExtensions
    {
        public static void ConfigureLookup<TEntity, TKey>(
            this EntityTypeBuilder<TEntity> builder,
            Expression<Func<TEntity, TKey>> expression,
            IEnumerable<TEntity> seedData)
            where TEntity : class
        {
            ArgumentNullException.ThrowIfNull(builder);

            // Fix: Cast the key expression to Expression<Func<TEntity, object?>>
            var keyExpression = Expression.Lambda<Func<TEntity, object?>>(
                Expression.Convert(expression.Body, typeof(object)),
                expression.Parameters);

            builder.HasKey(keyExpression);

            builder.Property("Name").IsRequired();

            builder.HasData(seedData);
        }
    }
}
