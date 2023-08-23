using Handson.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Handson.Infrastructure.Data.Mappings
{
    public class SubscriptionMap : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.HasKey(model => model.Id);

            builder.Property(model => model.Id);

            builder.Property(model => model.CreatedAt);

            builder.Property(model => model.ModifiedAt);

            builder.Property(model => model.ExpiresAt);

            builder.Property(model => model.Enabled);

            builder.Property(model => model.SubscriptionValue);

            builder.HasIndex(x => x.Enabled);

            builder.HasIndex(x => x.ExpiresAt);

            builder.HasMany(x => x.Payments)
                .WithOne()
                .HasForeignKey(x => x.SubscriptionId);

            builder.ToTable("Subscriptions");
        }
    }
}
