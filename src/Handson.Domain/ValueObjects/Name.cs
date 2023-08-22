using Handson.Shared.ValueObjects;

namespace Handson.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; init; }
        public string LastName { get; init; }
    }
}
