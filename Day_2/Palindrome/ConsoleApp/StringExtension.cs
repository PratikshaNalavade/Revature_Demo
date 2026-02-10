using System;

public static class StringExtensions
{
    public static bool IsPalindrome(this string s)
    {
        if (string.IsNullOrEmpty(s))
            return false;

        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }
}
