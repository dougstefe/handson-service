using Handson.Shared.ValueObjects;

namespace Handson.Core.DomainObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;
        }

        public string Address { get; init; }
    }
}
