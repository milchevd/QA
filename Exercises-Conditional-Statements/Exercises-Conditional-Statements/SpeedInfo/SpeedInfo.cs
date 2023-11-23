namespace SpeedInfo
{
    internal class SpeedInfo
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
                if (speed <= 30)
                    Console.WriteLine("Slow");
                else 
                    Console.WriteLine("Fast");
        }
    }
}