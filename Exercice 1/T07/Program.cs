namespace T07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veganMenu = int.Parse(Console.ReadLine());

            double chickenMenuPrice = chickenMenu * 10.35;
            double fishMenuPrice = fishMenu * 12.40;
            double veganMenuPrice = veganMenu * 8.15;
            double deliveryPrice = 2.50;

            double totalPriceMenu = chickenMenuPrice + fishMenuPrice + veganMenuPrice;
            double dessertPrice = (20 / 100.00) * totalPriceMenu;
            double totalOrderPrice = totalPriceMenu + dessertPrice + deliveryPrice;
            Console.WriteLine(totalOrderPrice);     
        }
    }
}