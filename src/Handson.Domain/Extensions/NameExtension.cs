using Handson.Domain.ValueObjects;
using Handson.Shared.Exceptions;

namespace Handson.Domain.Extensions
{
    public static class NameExtension
    {
        public static void ThrowIfInvalid(this Name name)
        {
            var message = $"The {nameof(Name)}.{{prop}} is null or empty.";
            if (string.IsNullOrEmpty(name.FirstName))
            {
                throw new DomainValidationException(string.Format(message, nameof(Name.FirstName)));
            }
            if (string.IsNullOrEmpty(name.LastName))
            {
                throw new DomainValidationException(string.Format(message, nameof(Name.LastName)));
            }
        }
    }
}
