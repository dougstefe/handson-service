using Handson.Shared.Entities;

namespace Handson.Domain.Entities
{
    public abstract class Payment : Entity
    {
        public Payment(decimal total)
        {
            Total = total;
        }

        public DateTime? PaidAt { get; private set; }
        public bool IsPaid { get; private set; }
        public decimal Total { get; private set; }
        public decimal? TotalPaid { get; private set; }

        public void Pay(decimal totalPaid)
        {
            TotalPaid = totalPaid;
            PaidAt = DateTime.UtcNow;
            IsPaid = true;
        }
    }
}
