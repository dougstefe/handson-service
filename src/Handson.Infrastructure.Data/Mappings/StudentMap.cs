using Handson.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Handson.Infrastructure.Data.Mappings
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(model => model.Id);

            builder.Property(model => model.Id);

            builder.Property(model => model.CreatedAt);

            builder.Property(model => model.ModifiedAt);

            builder.Property(model => model.DocumentNumber);

            builder.Property(model => model.Email)
                .HasMaxLength(100);

            builder.Property(model => model.Name)
                .HasMaxLength(100);

            builder.HasIndex(x => x.DocumentNumber)
                .IsUnique();
            builder.HasIndex(x => x.Email)
                .IsUnique();

            builder.HasMany(x => x.Addresses)
                .WithOne()
                .HasForeignKey(x => x.StudentId);

            builder.HasMany(x => x.Subscriptions)
                .WithOne()
                .HasForeignKey(x => x.StudentId);

            builder.ToTable("Students");
        }
    }
}
