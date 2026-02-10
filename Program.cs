// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class FactorialProgram
{
    static void Main()
    {
        int num = 5;
        long factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine("Factorial of " + num + " is: " + factorial);
    }
}