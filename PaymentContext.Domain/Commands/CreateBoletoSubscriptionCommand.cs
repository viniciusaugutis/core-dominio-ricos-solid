﻿using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Commands
{
    public class CreateBoletoSubscriptionCommand : Notifiable, ICommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string BarCode { get; set; }
        public string BoletoNumber { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string Payer { get; set; }
        public string PayerDocument { get; set; }

        public EDocumentoType PayerDocumentType { get; set; }

        public string PaymentNumber { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string PayerEmail { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract().Requires().HasMinLen(FirstName, 5, "Name.Firstname", "Nome deve conter pelo menos 5 caracteres")
                            .HasMinLen(LastName, 5, "Name.Firstname", "Sobrenome deve conter pelo menos 5 caracteres")
                            .HasMaxLen(LastName, 40, "Name.Firstname", "Nome deve conter no máximo 40 caracteres"));
        }
    }
}
