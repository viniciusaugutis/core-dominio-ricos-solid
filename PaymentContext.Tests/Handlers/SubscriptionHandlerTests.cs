using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    class SubscriptionHandlerTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.BarCode = "123456789";
            command.FirstName = "vini";
            command.LastName = "augutis";
            command.Document = "99999999999";
            command.Email = "vinii@email.com";
            command.BoletoNumber = "121212";
            command.PaymentNumber = "121212";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "vini";
            command.PayerDocument = "99999999999";
            command.PayerDocumentType = EDocumentoType.CPF;
            command.PayerEmail = "vini@email.com";
            command.Street = "1";
            command.Neighborhood = "1";
            command.City = "1";
            command.Number = "1";
            command.State = "1";
            command.Country = "1";
            command.ZipCode = "1";

            handler.Handle(command);

            Assert.AreEqual(false, handler.Valid);

        }

    }
}
