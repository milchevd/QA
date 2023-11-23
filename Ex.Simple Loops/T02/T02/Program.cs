namespace T02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int biggestNumber = int.MinValue;
            int sumOfAll = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > biggestNumber)
                    biggestNumber = number;
                    sumOfAll += number;
            }
            sumOfAll = sumOfAll - biggestNumber;
                if (sumOfAll == biggestNumber)
                {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum {sumOfAll}");
                }
                else 
                {
                int diff = Math.Abs(sumOfAll - biggestNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
                }
                
        }
    }
}