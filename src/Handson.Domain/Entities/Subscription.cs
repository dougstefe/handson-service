using Handson.Shared.Entities;

namespace Handson.Domain.Entities
{
    public class Subscription : Entity
    {
        private List<Payment> _payments;

        public Subscription(decimal subscriptionValue)
        {
            SubscriptionValue = subscriptionValue;
            _payments = new List<Payment>();
        }

        public bool Enabled { get; private set; }
        public DateTime? ExpiresAt { get; private set; }
        public decimal SubscriptionValue { get; private set; }

        public Student Student { get; private set; }
        public Guid StudentId { get; private set; }

        public IReadOnlyCollection<Payment> Payments => _payments;

        public void AddPayment(Payment newPayment)
        {
            _payments.Add(newPayment);
        }

        public void Disable()
        {
            Enabled = false;
        }
    }
}
