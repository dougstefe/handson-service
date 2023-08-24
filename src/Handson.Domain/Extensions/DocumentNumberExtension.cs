using Handson.Domain.ValueObjects;
using Handson.Shared.Exceptions;

namespace Handson.Domain.Extensions
{
    public static class DocumentNumberExtension
    {
        public static void ThrowIfInvalid(this DocumentNumber documentNumber)
        {
            var message = $"The {nameof(DocumentNumber)}.{{prop}} is null or empty.";
            if (documentNumber is null || string.IsNullOrEmpty(documentNumber.Number))
            {
                throw new DomainValidationException(string.Format(message, nameof(DocumentNumber.Number)));
            }
        }
    }
}
