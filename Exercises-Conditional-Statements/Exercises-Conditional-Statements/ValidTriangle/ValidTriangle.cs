namespace ValidTriangle
{
    internal class ValidTriangle
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

                if (a + b <= c)
                    Console.WriteLine("Invalid Triangle");
                else if (b + c <= a)
                    Console.WriteLine("Invalid Triangle");
                else if (a + c <= b)
                    Console.WriteLine("Invalid Triangle");
                else
                    Console.WriteLine("Valid Triangle");
        }
    }
}