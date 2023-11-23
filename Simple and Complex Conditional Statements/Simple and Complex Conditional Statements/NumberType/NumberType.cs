namespace NumberType
{
    internal class NumberType
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
                Console.WriteLine("zero ");
            else if (num > 0)
                Console.WriteLine("positive ");
            else Console.WriteLine("negative");
        }
    }
}