using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var doc = new Document("123", EDocumentoType.CNPJ);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenCNPJIsValid()
        {
            var doc = new Document("29386638000194", EDocumentoType.CNPJ);
            Assert.IsTrue(doc.Valid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenCPFIsInvalid()
        {
            var doc = new Document("6851383608", EDocumentoType.CPF);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("44121322002")]
        [DataRow("64698397030")]
        [DataRow("61854968017")]
        public void ShouldReturnErrorWhenCPFIsValid(string cpf)
        {
            var doc = new Document(cpf, EDocumentoType.CPF);
            Assert.IsTrue(doc.Valid);
        }
    }
}
