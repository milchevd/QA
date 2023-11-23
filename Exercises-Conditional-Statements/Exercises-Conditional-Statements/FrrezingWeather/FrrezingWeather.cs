using System.Threading.Channels;

namespace FrrezingWeather
{
    internal class FrrezingWeather
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());

                if (temp < 0)

                    Console.WriteLine("Freezing weather!");
        }
    }
}