using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name: ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            if (string.IsNullOrEmpty(firstName))
                AddNotification("Name.Firstname", "Nome inválido");
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
