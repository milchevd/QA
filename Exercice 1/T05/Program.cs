namespace T05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int penPackages = int.Parse(Console.ReadLine());
            int markerPacks = int.Parse(Console.ReadLine());
            int boardcleanerLiters = int.Parse(Console.ReadLine());
            int discountPerc = int.Parse(Console.ReadLine());

            double pensPrice = penPackages * 5.80;
            double markersPrice = markerPacks * 7.20;
            double boardcleanerPrice = boardcleanerLiters * 1.20;

            double totalPrice = pensPrice + markersPrice + boardcleanerPrice;
            double discount = discountPerc / 100.00;
            double neededMoney = totalPrice - (totalPrice * discount);

            Console.WriteLine(neededMoney);
        }
    }
}