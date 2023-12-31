﻿using Handson.Shared.ValueObjects;

namespace Handson.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;
        }

        public string Address { get; private set; }

        public override string ToString() => Address;
    }
}
