// See https://aka.ms/new-console-template for more information
using System.Dynamic;

namespace EventHandlerDemo;

public class onClickEventArgs : EventArgs
{
    public string buttonName {get; set;}
}

public class Button
{
    public delegate void onClickHandler();

    public event onClickHandler OnClick;

    public void click()
    {
        OnClick?.Invoke();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Button button=new Button();
        button.OnClick += () => Console.WriteLine("Bell Rings");
        button.OnClick += () => Console.WriteLine("Charge for electricity");
        button.OnClick += () => Console.WriteLine("Open the door");

        button.click();
    }
}