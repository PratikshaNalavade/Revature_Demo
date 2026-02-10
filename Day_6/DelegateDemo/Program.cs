// See https://aka.ms/new-console-template for more information
namespace DelegateDemo;
class Program{
static void Main(string[] args)
{
    DelegateDemoApp demo=new DelegateDemoApp();
    demo.Run();
    
}
}


class DelegateDemoApp
{
    delegate int MathOperation(int a, int b);
    public void Run()
    {
        MathOperation operation=Add;
        //multicast delegate
        operation += Sub;
        operation += Mul;
        operation += Div;

        operation -= Div; //removing method 
        var result= operation(5,3);
        Console.WriteLine( $"Final Result: {result}");

        
    }
    public int Add(int a, int b)
    {
        Console.WriteLine($"The sum of {a} and {b} is:{a+b}");
        return a+b;
    }
    public int Sub(int a, int b)
    {
        Console.WriteLine($"The difference between of {a} and {b} is:{a-b}");
        return a-b;
    }
    public int Mul(int a, int b)
    {
        Console.WriteLine($"The product of {a} and {b} is:{a*b}");
        return a*b;
    }
    public int Div(int a, int b)
    {
        Console.WriteLine($"The division of {a} and {b} is:{a/b}");
        return a/b;
    }
}

