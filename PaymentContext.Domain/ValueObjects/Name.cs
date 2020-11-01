using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract().Requires().HasMinLen(firstName, 5, "Name.Firstname", "Nome deve conter pelo menos 5 caracteres")
                .HasMinLen(lastName, 5, "Name.Firstname", "Sobrenome deve conter pelo menos 5 caracteres")
                .HasMaxLen(firstName, 40, "Name.Firstname", "Nome deve conter no máximo 40 caracteres"));

        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
