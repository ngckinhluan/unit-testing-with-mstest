using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeService.UnitTests;
[TestClass]
public class PalindromeServiceTest
{
    private readonly PalindromeService _palindromeService = new();
    
    [TestMethod]
    public void IsPalindrome_EmptyString_ReturnsTrue()
    {
        bool result = _palindromeService.IsPalindrome("");
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsPalindrome_SingleCharacter_ReturnsTrue()
    {
        bool result = _palindromeService.IsPalindrome("a");
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        bool result = _palindromeService.IsPalindrome("madam");
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsPalindrome_InvalidPalindrome_ReturnsFalse()
    {
        bool result = _palindromeService.IsPalindrome("hello");
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsPalindrome_CaseInsensitivePalindrome_ReturnsTrue()
    {
        bool result = _palindromeService.IsPalindrome("Radar");
        Assert.IsTrue(result);
    }
    

    
}