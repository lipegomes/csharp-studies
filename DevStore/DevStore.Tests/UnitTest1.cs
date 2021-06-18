using DevStore.Domain.StoreContext.Entities;
using DevStore.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = new Name("Filipe", "Gomes");
            var document = new Document("00000000000");
            var email = new Email("test@foobar.com");
            var c = new Customer(name, document, email, "01000000000");
            var mouse = new Product("Mouse", "Rato", "image.png", 65.90M, 10);
            var teclado = new Product("Teclado", "Teclado", "image.png", 256.99M, 10);
            var impressora = new Product("Impressora", "Impressora", "image.png", 434.75M, 10);
            var cadeira = new Product("Cadeira", "Cadeira", "image.png", 498.90M, 10);

            var order = new Order(c);

            // Realizei pedido
            order.Place();

            // Verificar se o pedido é valido
            var valid = order.IsValid;

            // Simular o pagamento
            order.Pay();

            // Simular o envio
            order.Ship();

            // Simular o cancelamento
            order.Cancel();
        }
    }
}
