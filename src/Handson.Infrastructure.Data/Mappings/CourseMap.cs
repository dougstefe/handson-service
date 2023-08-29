using Handson.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Handson.Infrastructure.Data.Mappings
{
    public class CourseMap : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(model => model.Id);

            builder.Property(model => model.Id);

            builder.Property(model => model.CreatedAt);

            builder.Property(model => model.ModifiedAt);

            builder.Property(model => model.Name)
                .HasMaxLength(50);

            builder.Property(model => model.Title)
                .HasMaxLength(50);

            builder.Property(model => model.Description)
                .HasMaxLength(300);

            builder.Property(model => model.Tags)
                .HasMaxLength(100);

            builder.HasIndex(x => x.Name)
                .IsUnique();
            builder.HasIndex(x => x.Title)
                .IsUnique();

            builder.HasIndex(x => x.Tags);

            builder.HasMany(x => x.Lessons)
                .WithOne()
                .HasForeignKey(x => x.CourseId);

            builder.ToTable("Courses");
        }
    }
}
