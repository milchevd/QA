namespace E05;
class T01
{
    static void Main__(string[] args)
    {
        for (int i = 7; i <= 997; i += 10)
        {
            Console.WriteLine(i);
        }
    }

    static void Main_(string[] args)
    {
        for (int i = 7; i <= 997; i++)
        {
            if (i % 10 == 7) // a number ends in 7, if it's modulo 10 result is 7
                Console.WriteLine(i);
        }
    }
}
