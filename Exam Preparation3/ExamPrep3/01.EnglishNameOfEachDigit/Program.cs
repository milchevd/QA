using System;

class Program
{
    // Function to convert digit to English name
    static string DigitToEnglishName(int digit)
    {
        string[] names = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        return names[digit];
    }

    static void Main(string[] args)
    {
        // Read input from the user
        int number = int.Parse(Console.ReadLine());

        // Convert and print English names of digits
        while (number > 0)
        {
            int digit = number % 10;
            Console.WriteLine(DigitToEnglishName(digit));
            number = number / 10;
        }
    }
}
