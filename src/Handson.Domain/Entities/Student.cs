using Handson.Domain.ValueObjects;
using Handson.Shared.Entities;

namespace Handson.Domain.Entities
{
    public class Student : Entity
    {
        private List<Address> _addresses;
        private List<Subscription> _subscriptions;

        public Student(DocumentNumber documentNumber, Email email, Name name, Address address)
        {
            DocumentNumber = documentNumber;
            Email = email;
            Name = name;
            _subscriptions = new List<Subscription>();
            _addresses = new List<Address>();
        }

        public DocumentNumber DocumentNumber { get; private set; }
        public Email Email { get; private set; }
        public Name Name { get; private set; }
        public IReadOnlyCollection<Address> Addresses => _addresses;

        public IReadOnlyCollection<Subscription> Subscriptions => _subscriptions;

        public void AddSubscription(Subscription newSubscription)
        {
            foreach (var subscription in Subscriptions)
            {
                subscription.Disable();
            }
            _subscriptions.Add(newSubscription);
        }

        public void AddAddress(Address newAddress)
        {
            _addresses.RemoveAll(x => x.Type == newAddress.Type);
            _addresses.Add(newAddress);
        }

    }
}
