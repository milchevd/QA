namespace T03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favourite = Console.ReadLine();
            string current = Console.ReadLine();

            int checkedBooks = 0;

                while (current != "No More Books" && current != favourite)
                {
                    checkedBooks++;
                    current = Console.ReadLine();
                }
            if (current == favourite)
                Console.WriteLine($"You checked {checkedBooks} books and found it.");
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");
            }    

        }
    }
}