using Handson.Domain.Entities;
using Handson.Shared.Exceptions;

namespace Handson.Domain.Extensions
{
    public static class AddressExtension
    {
        public static void ThrowIfInvalid(this Address address)
        {
            var message = $"The {nameof(Address)}.{{prop}} is null or empty.";
            if (string.IsNullOrEmpty(address.City))
            {
                throw new DomainValidationException(string.Format(message, nameof(Address.City)));
            }
            if (string.IsNullOrEmpty(address.ZipCode))
            {
                throw new DomainValidationException(string.Format(message, nameof(Address.ZipCode)));
            }
        }
    }
}
