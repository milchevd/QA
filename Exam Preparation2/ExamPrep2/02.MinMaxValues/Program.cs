using System;

class Program
{
    static void Main()
    {
        // Read array of integer numbers from the first line of the console
        string[] inputNumbers = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(inputNumbers, int.Parse);

        // Read an integer number N from the second line of the console
        int N = int.Parse(Console.ReadLine());

        // Find max number in the first N elements in the given array
        int maxNumber = int.MinValue;
        for (int i = 0; i < N && i < numbers.Length; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }

        // Find min number in the first N elements in the given array
        int minNumber = int.MaxValue;
        for (int i = 0; i < N && i < numbers.Length; i++)
        {
            if (numbers[i] < minNumber)
            {
                minNumber = numbers[i];
            }
        }

        // Print max number and min number, each on a separate line
        Console.WriteLine(maxNumber);
        Console.WriteLine(minNumber);
    }
}
