using Handson.Domain.Entities;
using Handson.Shared.Exceptions;

namespace Handson.Domain.Extensions
{
    public static class PaymentExtension
    {
        public static void ThrowIfInvalid(this Payment payment)
        {
            var message = $"The {nameof(Payment)}.{{prop}} is zero.";
            if (payment.Total <= 0)
            {
                throw new DomainValidationException(string.Format(message, nameof(Payment.Total)));
            }
        }
    }
}
