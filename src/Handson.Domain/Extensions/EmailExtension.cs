using Handson.Domain.ValueObjects;
using Handson.Shared.Exceptions;

namespace Handson.Domain.Extensions
{
    public static class EmailExtension
    {
        public static void ThrowIfInvalid(this Email email)
        {
            var message = $"The {nameof(Email)}.{{prop}} is null or empty.";
            if (email is null || string.IsNullOrEmpty(email.Address))
            {
                throw new DomainValidationException(string.Format(message, nameof(Email.Address)));
            }
        }
    }
}
