using Handson.Shared.ValueObjects;

namespace Handson.Domain.ValueObjects
{
    public class DocumentNumber : ValueObject
    {
        public DocumentNumber(string number)
        {
            Number = number;
        }
        public string Number { get; init; }
    }
}
