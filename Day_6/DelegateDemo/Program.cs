// See https://aka.ms/new-console-template for more information
using System.Data;

namespace DelegateDemo;
class Program{
static void Main(string[] args)
{
    DelegateDemoApp demo=new DelegateDemoApp();
    //demo.Run();
    demo.HigherOrderFunctionDemo();
}
}


class DelegateDemoApp
{
    //event example
   public void HigherOrderFunctionDemo()
    {
        var Result =CalculateArea(AreaOfRectangle);
        Console.WriteLine($"Area: {Result}");
        
    }
    int CalculateArea(Func<int, int, int> areaFunction)
    {
        return areaFunction(5,10);
    }
    int AreaOfRectangle(int length, int width)
    {
        return length * width;
    }
    
    //lambda Expression 
    delegate int MathOperation(int a, int b);

     public void LambdaExpressionDemo()
    {
        Func<int, int> f;
        f=(int x) => x * x;
        var result=f(5);
        Console.WriteLine($"result: {result}");

    }
    public void AnonymousMethodDemo()
    {
        MathOperation operation=delegate(int a, int b)
        {
            Console.WriteLine($"The sum of {a} and {b} is: {a+b}");
            return a+b;
        };
        operation(5,3);
    }
    public void Run()
    {
        // MathOperation operation=Add;
        // //multicast delegate
        // operation += Sub;
        // operation += Mul;
        // operation += Div;

        // operation -= Div; //removing method 
        // var result= operation(5,3);
        // Console.WriteLine( $"Final Result: {result}");

        LambdaExpressionDemo();
        
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

