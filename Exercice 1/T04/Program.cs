namespace T04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int totalReadTime = pages / pagesPerHour;
            int totalHours = totalReadTime / days;
            Console.WriteLine(totalHours);
        }
    }
}