namespace ThreeNumbers
{
    internal class ThreeNumbers
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            int countNegative = 0;

            if (num1 == 0 || num2 == 0 || num3 == 0)
                Console.WriteLine("zero");
            else
            {

                if (num1 < 0)
                    countNegative++;
                if (num2 < 0)
                    countNegative++;
                if (num3 < 0)
                    countNegative++;
                if (countNegative % 2 == 0)
                    Console.WriteLine("positive");
                else
                    Console.WriteLine("negative");
            }
        }
    }
}