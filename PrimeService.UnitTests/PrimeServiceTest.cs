using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeService.UnitTests
{
    [TestClass]
    public class PrimeServiceTest
    {
        private readonly PrimeService _primeService = new();

        [TestMethod]
        public void IsPrime_InputIs1_ReturnFalse()
        {  
            bool result = _primeService.IsPrime(1);
            Assert.IsFalse(result, "1 should not be prime");
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            bool result = _primeService.IsPrime(value);
            Assert.IsFalse(result, $"{value} should not be prime");
        }

        [TestMethod]
        public void IsPrime_InputIs4_ReturnFalse()
        {
            bool result = _primeService.IsPrime(4);
            Assert.IsFalse(result, "4 should not be prime");
        }

        [TestMethod]
        public void IsPrime_InputIs5_ReturnTrue()
        {
            bool result = _primeService.IsPrime(5);
            Assert.IsTrue(result, "5 should be prime");
        }
    }
}
