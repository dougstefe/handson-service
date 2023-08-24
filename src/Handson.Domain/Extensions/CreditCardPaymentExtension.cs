using Handson.Domain.Entities;
using Handson.Shared.Exceptions;

namespace Handson.Domain.Extensions
{
    public static class CreditCardPaymentExtension
    {
        public static void ThrowIfInvalid(this CreditCardPayment boleto)
        {
            var message = $"The {nameof(CreditCardPayment)}.{{prop}} is null or empty.";
            if (string.IsNullOrEmpty(boleto.Number))
            {
                throw new DomainValidationException(string.Format(message, nameof(CreditCardPayment.Number)));
            }
        }
    }
}
