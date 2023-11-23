static int Factorial(int n)
{
    if (n == 0 || n == 1)
    {
        return 1; //защото 0! = 1 и 1! = 1 по дефиниция
    }
    else
    {
        int factorial = 1;
        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}

int number = int.Parse(Console.ReadLine());

        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 == 0)
            {
                sum += Factorial(digit);
            }
            number /= 10;
        }

        Console.WriteLine(sum);
    

    

