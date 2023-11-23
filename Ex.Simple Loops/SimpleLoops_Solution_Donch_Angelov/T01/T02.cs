namespace E05;
class T02
{
    static void Main_(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        int sum = 0;
        int max = int.MinValue;

        for (int c = 0; c < count; c++)
        {
            int cur = int.Parse(Console.ReadLine());

            sum += cur; // accumulate the total sum of all the numbers

            // remember the biggest number from all the input
            if (cur > max)
                max = cur;
        }

        sum -= max; // take out the biggest number, so that we can compare

        if (sum == max)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {sum}");
        }
        else
        {
            int diff = Math.Abs(sum - max); // the absolute difference between sum and max
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {diff}");
        }

    }
}

/*
2
Income
3
Game Info
6
Best Player
4


*/