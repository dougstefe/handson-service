using Handson.Shared.ValueObjects;

namespace Handson.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string street, string complement, string district, string city, string fU, string zipCode)
        {
            Street = street;
            Complement = complement;
            District = district;
            City = city;
            FU = fU;
            ZipCode = zipCode;
        }

        public string Street { get; private set; }
        public string Complement { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        public string FU { get; private set; }
        public string ZipCode { get; private set; }
    }
}
