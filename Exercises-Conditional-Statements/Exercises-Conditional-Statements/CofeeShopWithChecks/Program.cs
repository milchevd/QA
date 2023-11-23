namespace CofeeShopWithChecks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string extra = Console.ReadLine();
            double price = 0.00;

            if (drink == "coffee")
                price = 1.00;
            else if (drink == "tea")
                price = 0.60;
            else
            { 
                Console.WriteLine("Unknown drink");
                return;
            }
            if (extra == "sugar")
                price = price + 0.40;
            else if (extra == "no")
                price = price + 0.00;
            else 
            { 
                Console.WriteLine("Unknown extra");
                return;
            }

                Console.WriteLine($"Final price: ${price:f2}");
        }
    }
}