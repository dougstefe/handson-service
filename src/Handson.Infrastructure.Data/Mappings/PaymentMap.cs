using Handson.Domain.Entities;
using Handson.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Handson.Infrastructure.Data.Mappings
{
    public class PaymentMap : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(model => model.Id);

            builder.Property(model => model.Id);

            builder.Property(model => model.CreatedAt);

            builder.Property(model => model.ModifiedAt);

            builder.Property(model => model.PaidAt);

            builder.Property(model => model.IsPaid);

            builder.Property(model => model.Total);

            builder.Property(model => model.TotalPaid);

            builder.Property(model => model.Method);

            builder.HasIndex(x => x.IsPaid);

            builder.HasIndex(x => x.PaidAt);

            builder.HasIndex(x => x.Total);

            builder.HasIndex(x => x.TotalPaid);

            builder.HasDiscriminator<int>(name: "Method")
                .HasValue<BoletoPayment>(value: Convert.ToInt32(value: PaymentMethod.Boleto))
                .HasValue<CreditCardPayment>(value: Convert.ToInt32(value: PaymentMethod.CreditCard));

            builder.ToTable("Payments");
        }
    }
}
