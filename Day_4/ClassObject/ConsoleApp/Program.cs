// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Using default constructor
            Person p1 = new Person();
            p1.Display();

            //  Using overloaded constructor
            Person p2 = new Person("Pratiksha", 22);
            p2.Display();

            //  Validation check
            try
            {
                Person p3 = new Person("", -5);
                p3.Display();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
