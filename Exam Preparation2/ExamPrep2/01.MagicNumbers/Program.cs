using System;

public static class Program
{
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        bool hasMagicNumbers = false;
        

        for (int i = 1; i <= N; i++)
        {
            if (IsMagicNumber(i))
            {
                Console.Write(i + " ");
                hasMagicNumbers = true;
            }
        }

        if (!hasMagicNumbers)
        {
            Console.WriteLine("no");
        }
    }

    public static bool IsMagicNumber(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            if (!IsPrime(digit))
            {
                return false;
            }
            sum += digit;
            number /= 10;
        }
        return sum % 2 == 0;
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
