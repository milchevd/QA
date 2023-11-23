namespace VacationExpenses
{
    internal class VacationExpenses
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string type = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            if (season == "Spring")
                if (type == "Hotel")
                    totalPrice = 30 * days * 0.8;
                else
                    totalPrice = 10 * days * 0.8;
            if (season == "Summer")
                if (type == "Hotel")
                    totalPrice = 50 * days;
                else
                    totalPrice = 30 * days;
            if (season == "Autumn")
                if (type == "Hotel")
                    totalPrice = 20 * days * 0.7;
                else
                    totalPrice = 15 * days * 0.7;
            if (season == "Winter")
                if (type == "Hotel")
                    totalPrice = 40 * days * 0.9;
                else
                    totalPrice = 10 * days * 0.9;

            Console.WriteLine($"{totalPrice:F2}");

        }
    }
}