using Handson.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Handson.Infrastructure.Data.Mappings
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(model => model.Id);

            builder.Property(model => model.Id);

            builder.Property(model => model.CreatedAt);

            builder.Property(model => model.ModifiedAt);

            builder.Property(model => model.Type);

            builder.Property(model => model.Street);

            builder.Property(model => model.Complement);

            builder.Property(model => model.District);

            builder.Property(model => model.City);

            builder.Property(model => model.FU);

            builder.Property(model => model.ZipCode);

            builder.ToTable("Addresses");
        }
    }

}
