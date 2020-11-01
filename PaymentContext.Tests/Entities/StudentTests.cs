using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            /*var subscription = new Subscription(null);
            var student = new Student("Vinicius", "Augutis", "4399910212", "vini@email.com");
            student.AddSubscription(subscription);*/

            var name = new Name("Teste", "Teste");
            foreach(var not in name.Notifications)
            {
                //not.Message;
            }
        }
    }
}
