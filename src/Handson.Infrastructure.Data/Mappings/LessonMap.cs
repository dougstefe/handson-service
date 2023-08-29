using Handson.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Handson.Infrastructure.Data.Mappings
{
    public class LessonMap : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.HasKey(model => model.Id);

            builder.Property(model => model.Id);

            builder.Property(model => model.CreatedAt);

            builder.Property(model => model.ModifiedAt);

            builder.Property(model => model.Name);

            builder.Property(model => model.Description);

            builder.Property(model => model.Order);

            builder.Property(model => model.DurationInSeconds);

            builder.HasIndex(x => x.Name);

            builder.HasIndex(x => x.Description);

            builder.ToTable("Lessons");
        }
    }
}
