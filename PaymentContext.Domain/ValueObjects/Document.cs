using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentoType type)
        {
            Number = number;
            Type = type;
        }
        public string Number { get; private set; }

        public EDocumentoType Type { get; private set; }

    }
}
