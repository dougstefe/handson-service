using Handson.Shared.Entities;

namespace Handson.Domain.Entities
{
    public class Subscription : Entity
    {
        private List<Payment> _payments;

        public Subscription()
        {
            _payments = new List<Payment>();
        }

        public bool Enabled { get; private set; }

        public DateTime? ExpiresAt { get; private set; }

        public IReadOnlyCollection<Payment> Payments => _payments;

        public void Disable()
        {
            Enabled = false;
        }
    }
}
