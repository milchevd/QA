namespace BonusScore
{
    internal class BonusScore
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            int bonus = 0;

            if (points >= 0 && points <= 3)
                bonus = points + 5;
            else if (points >= 4 && points <= 6)
                bonus = points + 15;
            else if (points >= 7 && points <= 9)
                bonus = points + 20;

            Console.WriteLine(bonus);

        }
    }
}