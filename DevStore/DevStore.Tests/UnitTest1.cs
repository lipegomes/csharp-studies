using DevStore.Domain.StoreContext.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Customer(
                "Filipe",
                "de Lima",
                "000000000001",
                "foobar@foobar.com",
                "01000000001",
                "Avenue 100, number 7"
            );
        }
    }
}
