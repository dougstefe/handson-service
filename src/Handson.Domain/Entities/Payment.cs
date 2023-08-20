using Handson.Shared.Entities;

namespace Handson.Domain.Entities
{
    public abstract class Payment : Entity
    {
        public DateTime? PaidAt { get; private set; }
        public bool IsPaid{ get; private set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }


        public void Pay()
        {
            PaidAt = DateTime.UtcNow;
            IsPaid = true;
        }
    }
}
