namespace PrimeService;

public class FactorialService
{
    public int Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentOutOfRangeException(nameof(n), "Value cannot be negative.");
        if (n == 0 || n == 1)
            return 1;

        int result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}