using Handson.Core.DomainObjects;

namespace Handson.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public Name HolderName { get; set; }
        public string Number { get; set; }
    }
}
