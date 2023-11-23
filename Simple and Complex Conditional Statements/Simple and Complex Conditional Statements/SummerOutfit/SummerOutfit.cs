namespace SummerOutfit
{
    internal class SummerOutfit
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string clothing = "Shirt";
            string shoes = "Moccasins";

            
            if ((timeOfDay == "Morning" && temp >= 25) || (timeOfDay == "Afternoon" && temp > 18 && temp <= 24))
            {
                clothing = "T-Shirt";
                shoes = "Sandals";
            }
            else if (timeOfDay == "Morning" && temp <= 18)
            {
                clothing = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (timeOfDay == "Afternoon" && temp >= 25)
            {
                clothing = "Swim Suit";
                shoes = "Barefoot";
            }

            Console.WriteLine($"It's {temp} degrees, get your {clothing} and {shoes}.");
        }
    }
}