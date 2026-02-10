// // See https://aka.ms/new-console-template for more information
// using System.Runtime.CompilerServices;
// using GarbageCollectionDemo;

// namespace Day5
// {
//     class Program
//     {
//         public static void Main()
//         {
//             // var res1=new Resource("Res1"); //allocated on heap
//             // var res2=new Resource("Res2");
//             // res1=null; //res1 now eligible for collection 
//             // res1=res2; // rese still referenced
//             // GC.Collect(); //force collection(normally automatic)
//             // GC.WaitForPendingFinalizers();
//             // Console.WriteLine("GC Completed");
//             DisposableDemo();
//             RecordDemo();

//             Console.ReadLine();

//         }
        


//         private static void DisposableDemo()
//         {
//             using (var manager =new GarbageCollectionDemo.FileManager("DisposableRes"))
//             {
//                 manager.OpenFile("path/to/file.txt");
//             }

//             using var manager2=new GarbageCollectionDemo.FileManager("DisposabelRes");
//         }

//         private static void RecordDemo()
//         {
//             var temp1=new Temp{Id=1, Name="Temp1"};
//             var temp2=new Temp{Id=1, Name="Temp3"};

//             Console.WriteLine(temp1);
//             Console.WriteLine(temp2);
//             Console.WriteLine(temp1==temp2);

//             var temp3=temp1 with {Id=2};
//             Console.WriteLine(temp3);
//         }

//     }

// }


using System;
using RecordDemo;

namespace Day5
{
    class Program
    {
        static void Main()
        {
            DisposableDemo();
            RecordDemo();

            Console.ReadLine();
        }

        private static void DisposableDemo()
        {
            using (var manager = new FileManager("DisposableRes"))
            {
                manager.OpenFile("test.txt");
                Console.WriteLine("Using FileManager");
            } // Dispose called automatically here

            using var manager2 = new FileManager("DisposableRes2");
            manager2.OpenFile("test2.txt");
            // Dispose called at end of scope
        }
        

        private static void RecordDemo()
        {
            var temp1 = new Temp { Id = 1, Name = "Temp1" };
            var temp2 = new Temp { Id = 2, Name = "Temp2" };
            

            Console.WriteLine(temp1);
            Console.WriteLine(temp2);
            Console.WriteLine(temp1 == temp2);

            var temp3  = temp1 with { Id =2};
            Console.WriteLine(temp3);
        }
    }
}