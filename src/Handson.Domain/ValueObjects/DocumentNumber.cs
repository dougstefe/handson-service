using Handson.Shared.ValueObjects;

namespace Handson.Core.DomainObjects
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
