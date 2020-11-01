using PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(string cardHolderName, string cardNumber, string lastTransactionCode, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Address address, Document document, string payer, Email email)
            : base(paidDate, expireDate, total, totalPaid, address, document, payer, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionCode = lastTransactionCode;
        }

        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionCode { get; private set; }

    }

}
