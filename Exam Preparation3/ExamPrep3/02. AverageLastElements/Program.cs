using System;

class Program
{
    static void Main()
    {
        // Read the array of integers from the first line of the console
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        // Read an integer N from the second line of the console
        int N = int.Parse(Console.ReadLine());

        // Calculate the sum of the last N elements in the array
        int sum = 0;
        int count = 0;
        for (int i = Math.Max(0, numbers.Length - N); i < numbers.Length; i++)
        {
            sum += numbers[i];
            count++;
        }

        // Calculate the average value of the last N elements in the array
        double average = (double)sum / count;

        // Print the average value
        Console.WriteLine($"{ average:F2}");
    }
}
