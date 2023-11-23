namespace VowelOrConsonant
{
    internal class VowelOrConsonant
    {
        static void Main(string[] args)
        {
            string ch = Console.ReadLine();

            {
                if (ch == "A" || ch == "a" ||
                    ch == "E" || ch == "e" ||
                    ch == "I" || ch == "i" ||
                    ch == "O" || ch == "o" ||
                    ch == "U" || ch == "u")
                    Console.WriteLine("Vowel");
                else
                    Console.WriteLine("Consonant");
            }

        }
    }
}