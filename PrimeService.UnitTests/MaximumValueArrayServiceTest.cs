using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeService.UnitTests
{
    [TestClass]
    public class MaximumValueArrayServiceTests
    {
        [TestMethod]
        public void FindMax_WithValidArray_ReturnsMaximumValue()
        {
            // Arrange
            var service = new MaximumValueArrayService();
            int[] numbers = { 5, 2, 8, 1, 9 };

            // Act
            int result = service.FindMax(numbers);

            // Assert
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void FindMax_WithEmptyArray_ThrowsArgumentException()
        {
            // Arrange
            var service = new MaximumValueArrayService();
            int[] numbers = new int[0];

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => service.FindMax(numbers));
        }

        [TestMethod]
        public void FindMax_WithNullArray_ThrowsArgumentException()
        {
            // Arrange
            var service = new MaximumValueArrayService();
            int[] numbers = null;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => service.FindMax(numbers));
        }

        [TestMethod]
        public void FindMax_WithSingleElementArray_ReturnsSingleElement()
        {
            // Arrange
            var service = new MaximumValueArrayService();
            int[] numbers = { 42 };

            // Act
            int result = service.FindMax(numbers);

            // Assert
            Assert.AreEqual(42, result);
        }
    }
}