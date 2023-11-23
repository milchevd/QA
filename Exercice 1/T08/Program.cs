namespace T08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualTrainingFee = int.Parse(Console.ReadLine());

            // Calculate expenses
            double sneakersPrice = annualTrainingFee - (annualTrainingFee * 0.4);
            double teamPrice = sneakersPrice -(sneakersPrice * 0.2);
            double basketballPrice = teamPrice / 4;
            double accessoriesPrice = basketballPrice / 5;

            // Total expenses
            double totalExpenses = annualTrainingFee + sneakersPrice + teamPrice + basketballPrice + accessoriesPrice;

            // Output
            Console.WriteLine(totalExpenses);
            Console.ReadLine();
        }
    }
}