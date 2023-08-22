using Handson.Core.DomainObjects;

namespace Handson.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(Name holderName, string number, decimal total) : base(total)
        {
            HolderName = holderName;
            Number = number;
        }

        public Name HolderName { get; set; }
        public string Number { get; set; }
    }
}
