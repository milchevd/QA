namespace T09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double perc = double.Parse(Console.ReadLine());

            double volumeLiters = length * width * height * 0.001;
            double waterperc = 1 - perc / 100;
            Console.WriteLine($"{volumeLiters * waterperc:F2}");
        }
    }
}