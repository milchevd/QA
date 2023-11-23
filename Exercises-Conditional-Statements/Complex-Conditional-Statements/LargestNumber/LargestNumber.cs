namespace LargestNumber
{
    internal class LargestNumber
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int maxNumber = 0;

            if (num1 > num2 && num1 > num3)
            {
                maxNumber = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                maxNumber = num2;
            }
            else
            {
                maxNumber = num3;
            }

            Console.WriteLine(maxNumber);

        }
    }
}