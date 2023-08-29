using Handson.Domain.Enums;
using Handson.Domain.Extensions;
using Handson.Shared.Entities;

namespace Handson.Domain.Entities
{
    public class Address : Entity
    {
        public Address(AddressType type, string street, string complement, string district, string city, string fU, string zipCode)
        {
            Type = type;
            Street = street;
            Complement = complement;
            District = district;
            City = city;
            FU = fU;
            ZipCode = zipCode;

            this.ThrowIfInvalid();
        }
        public AddressType Type { get; set; }
        public string Street { get; private set; }
        public string Complement { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        public string FU { get; private set; }
        public string ZipCode { get; private set; }

        public Student Student { get; private set; }
        public Guid StudentId { get; private set; }
    }
}
