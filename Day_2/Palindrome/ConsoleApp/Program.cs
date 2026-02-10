// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


class Program
{
    static void Main()
    {
        Console.WriteLine("madam".IsPalindrome());     // true
        Console.WriteLine("RaceCar".IsPalindrome());   // true
        Console.WriteLine("hello".IsPalindrome());     // false
        Console.WriteLine("".IsPalindrome());          // false
    }
}
