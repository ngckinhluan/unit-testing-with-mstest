using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeService.UnitTests;
[TestClass]
public class FactorialServiceTest
{
    private readonly FactorialService _factorialService = new();
    [TestMethod]
    public void Factorial_InputIsZero_ReturnsOne()
    {
        int result = _factorialService.Factorial(0);
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Factorial_InputIsOne_ReturnsOne()
    {
        int result = _factorialService.Factorial(1);
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Factorial_InputIsPositive_ReturnsCorrectFactorial()
    {
        int result = _factorialService.Factorial(5);
        Assert.AreEqual(120, result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Factorial_InputIsNegative_ThrowsArgumentOutOfRangeException()
    {
        _factorialService.Factorial(-1);
    }
}