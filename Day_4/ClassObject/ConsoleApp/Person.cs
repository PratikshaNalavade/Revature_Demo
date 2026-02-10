using System;

namespace ConsoleApp
{
    public class Person
    {
        // 🔒 Private fields
        private string _name;
        private int _age;

        // ✅ Public properties with validation
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty");

                _name = value;
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Age cannot be negative");

                _age = value;
            }
        }

        // 🔹 Default constructor
        public Person()
        {
            Name = "Unknown";
            Age = 0;
        }

        // 🔹 Overloaded constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // 🔹 Method to display details
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
