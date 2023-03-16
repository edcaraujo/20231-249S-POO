namespace example_005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short x = 23;
            int y = x;
            long z = y;


            Console.WriteLine($"x: {x}");
            Console.WriteLine($"y: {y}");
            Console.WriteLine($"z: {z}");  
            
            long a = 97298718912123912;
           int b = (int) a;
            short c = (short) b;

            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");

        }
    }
}