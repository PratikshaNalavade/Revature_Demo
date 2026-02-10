namespace Day5
{
    public class Resource
    {
        public string Name {get; set;}

        public Resource(String name)
        {
            Name=name;
            Console.WriteLine($"{Name} created");
        }

        ~Resource()
        {
            Console.WriteLine($"{Name} destroyed by GC");
        }
    }
}