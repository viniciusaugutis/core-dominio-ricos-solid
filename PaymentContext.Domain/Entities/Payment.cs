﻿using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment: Entity
    {
        protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Address address, Document document, string payer, Email email)
        {
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Address = address;
            Document = document;
            Payer = payer;
            Email = email;
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();

            AddNotifications(new Contract().Requires()
                .IsLowerOrEqualsThan(0, Total, "Payment.total", "O total não pode ser 0")
                .IsGreaterOrEqualsThan(Total, TotalPaid, "Payment.totalPaid", "O valor pago é menor que o valor do pagamento")
                );
        }

        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }

        public string Number { get; private set; }
        public Address Address { get; private set; }

        public Document Document { get; private set; }

        public string Payer { get; private set; }
        public Email Email { get; private set; }
    }

}
