namespace T06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int craftsmanHours = int.Parse(Console.ReadLine());
            double bags = 0.40;

            double nylonAmount = (nylon + 2.00) * 1.50;
            double paintAmount = paint * 1.1 * 14.50;
            double thinnerAmount = thinner * 5;
            double totalMaterials = nylonAmount + paintAmount + thinnerAmount + bags;
            double craftsmanTotalHours = (totalMaterials * (30 / 100.00)) * craftsmanHours;
            double totalAmount = totalMaterials + craftsmanTotalHours;
            Console.WriteLine(totalAmount);
            
            


        }
    }
}