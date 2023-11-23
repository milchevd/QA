namespace SumSeconds
{
    internal class SumSeconds
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int totalSec = num1 + num2 + num3;
            int minutes = totalSec / 60;
            int seconds = totalSec % 60;

            Console.WriteLine($"{minutes}:{seconds:D2}");
        }
    }
}