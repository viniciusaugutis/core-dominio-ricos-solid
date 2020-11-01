﻿using Flunt.Validations;
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

            AddNotifications(new Contract().Requires().IsTrue(Validate(), "Document.Number", "Documento inválido"));
        }
        public string Number { get; private set; }

        public EDocumentoType Type { get; private set; }
        private bool Validate()
        {

            if (Type == EDocumentoType.CNPJ && Number.Length == 14)
            {
                return true;
            }

            if (Type == EDocumentoType.CPF && Number.Length == 11)
            {
                return true;
            }

            return false;

        }

    }
}
