// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 7, 2, 9, 5 };

        // ---- out parameter version ----
        if (TryFindMax(numbers, out int max1))
        {
            Console.WriteLine($"[out] Max value: {max1}");
        }
        else
        {
            Console.WriteLine("[out] No max found");
        }

        // ---- tuple version ----
        var (success, max2) = TryFindMaxTuple(numbers);
        if (success)
        {
            Console.WriteLine($"[tuple] Max value: {max2}");
        }
        else
        {
            Console.WriteLine("[tuple] No max found");
        }
    }

    // 1️⃣ Try-pattern with out parameter
    static bool TryFindMax(int[] numbers, out int max)
    {
        if (numbers == null || numbers.Length == 0)
        {
            max = default;
            return false;
        }

        max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
                max = numbers[i];
        }

        return true;
    }

    // 2️⃣ Tuple-returning version
    static (bool Success, int Max) TryFindMaxTuple(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return (false, default);

        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
                max = numbers[i];
        }

        return (true, max);
    }
}
