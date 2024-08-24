namespace PrimeService;

public class MaximumValueArrayService
{
    public int FindMax(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Array cannot be null or empty.");

        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
}