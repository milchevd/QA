using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int sumOfEvenDigits = GetSumOfEvenDigits(number);
        int sumOfOddDigits = GetSumOfOddDigits(number);
        int result = GetMultipleOfEvenAndOdds(sumOfEvenDigits, sumOfOddDigits);

        
        Console.WriteLine(result);
    }

    static int GetSumOfEvenDigits(int number)
    {
        number = Math.Abs(number);
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 == 0)
            {
                sum += digit;
            }
            number /= 10;
        }
        return sum;
    }

    static int GetSumOfOddDigits(int number)
    {
        number = Math.Abs(number);
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 != 0)
            {
                sum += digit;
            }
            number /= 10;
        }
        return sum;
    }

    static int GetMultipleOfEvenAndOdds(int sumOfEvenDigits, int sumOfOddDigits)
    {
        return sumOfEvenDigits * sumOfOddDigits;
    }
}
