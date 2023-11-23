namespace T03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositedAmount = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double annualInterest = double.Parse(Console.ReadLine());

            double interest = depositedAmount * (annualInterest / 100.00);
            double monthlyInterest = interest / 12.00;
            double totalAmount = depositedAmount + (months * monthlyInterest);
            Console.WriteLine(totalAmount);
 

        }
    }
}