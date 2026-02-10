using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ArrayCollectionDemo
{
    public class ArrayCollection
    {
        // Array example
        public void ShowArray()
        {
            int[] numbers = { 10, 20, 30, 40 };

            Console.WriteLine("Array elements:");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }

        // Collection example using List<T>
        public void ShowCollection()
        {
            List<int> numbers = new List<int>();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);

            int sum = 0; 
            Console.WriteLine("Collection (List) elements:");
            foreach (int n in numbers)
            {
                Console.WriteLine($"n: {n}, type: {n.GetType()}");
                sum+=(int)n;
                
                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine();
            }
        }

        public void CollectionClassesDemo()
        {
            List<int> list=new List<int>();
            list.Add(1);
            list.Add(1);
            // list.Add(30);
            // list.Add(40);
            //list.Add("Pratu");  

            Console.WriteLine($"Count: {list.Count}, Capacity:{list.Capacity}");

            list.AddRange(new int[] {1,2,3});
            Console.WriteLine($"Count: {list.Count}, Capacity:{list.Capacity}");

            list.AddRange(new List<int> {4,5,6});
            Console.WriteLine($"Count: {list.Count}, Capacity:{list.Capacity}");

            list.AddRange(new List<int> {6,7,8});
            Console.WriteLine($"Count: {list.Count}, Capacity:{list.Capacity}");

            // foreach(int n in list)
            // {
            //     Console.WriteLine(n);
            // }
        }
        
    }
    
}
