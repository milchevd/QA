namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine(); 
            int rows = int.Parse(Console.ReadLine());   
            int seats = int.Parse(Console.ReadLine());
            double ticketPrice = rows * seats;
            double totalPrice = 0;

            if (movieName == "Premiere")
                totalPrice = ticketPrice * 12.00;
            else if (movieName == "Normal")
                totalPrice = ticketPrice * 7.50;
            else
                totalPrice = ticketPrice * 5.00;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}