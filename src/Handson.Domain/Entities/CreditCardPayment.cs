using Handson.Domain.Enums;
using Handson.Domain.Extensions;
using Handson.Domain.ValueObjects;

namespace Handson.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(Name holderName, string number, decimal total) : base(PaymentMethod.CreditCard, total)
        {
            HolderName = holderName;
            Number = number;

            this.ThrowIfInvalid();
        }

        public Name HolderName { get; private set; }
        public string Number { get; private set; }
    }
}
