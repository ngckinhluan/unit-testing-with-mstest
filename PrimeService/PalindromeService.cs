namespace PrimeService;

public class PalindromeService
{
    public bool IsPalindrome(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return true;
        
        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            if (char.ToLower(input[left]) != char.ToLower(input[right]))
                return false;

            left++;
            right--;
        }
        return true;
    }
}