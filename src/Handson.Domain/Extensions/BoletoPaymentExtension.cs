using Handson.Domain.Entities;
using Handson.Shared.Exceptions;

namespace Handson.Domain.Extensions
{
    public static class BoletoPaymentExtension
    {
        public static void ThrowIfInvalid(this BoletoPayment boleto)
        {
            var message = $"The {nameof(BoletoPayment)}.{{prop}} is null or empty.";
            if (string.IsNullOrEmpty(boleto.BarCode))
            {
                throw new DomainValidationException(string.Format(message, nameof(BoletoPayment.BarCode)));
            }
            if (string.IsNullOrEmpty(boleto.ControlNumber))
            {
                throw new DomainValidationException(string.Format(message, nameof(BoletoPayment.ControlNumber)));
            }
        }
    }
}
