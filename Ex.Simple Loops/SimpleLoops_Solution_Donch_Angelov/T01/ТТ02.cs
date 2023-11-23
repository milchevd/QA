using System;
namespace E05
{
	public class ТТ02
	{
		static void Main_()
		{
			int n = int.Parse(Console.ReadLine());

			int biggestNumber = 0; // int.MinValue;
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
				Console.WriteLine($"Sum = {sumOfAll}");
			}
			else
			{
				int diff = Math.Abs(sumOfAll - biggestNumber); // the absolute difference between sum and max
				Console.WriteLine("No");
				Console.WriteLine($"Diff = {diff}");
			}
		}
	}
}

