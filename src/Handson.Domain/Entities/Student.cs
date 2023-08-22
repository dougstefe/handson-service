using Handson.Domain.ValueObjects;
using Handson.Shared.Entities;

namespace Handson.Domain.Entities
{
    public class Student : Entity
    {
        private List<Subscription> _subscriptions;

        public Student(DocumentNumber documentNumber, Email email, Name name, Address address)
        {
            DocumentNumber = documentNumber;
            Email = email;
            Name = name;
            Address = address;
            _subscriptions = new List<Subscription>();
        }

        public DocumentNumber DocumentNumber { get; set; }
        public Email Email { get; set; }
        public Name Name { get; set; }
        public Address Address { get; set; }

        public IReadOnlyCollection<Subscription> Subscriptions => _subscriptions;

        public void AddSubscription(Subscription newSubscription)
        {
            foreach (var subscription in Subscriptions)
            {
                subscription.Disable();
            }
            _subscriptions.Add(newSubscription);
        }

    }
}
