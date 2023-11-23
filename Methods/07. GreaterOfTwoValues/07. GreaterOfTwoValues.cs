using System;

class Program
{
    static void Main()
    {
        
        string dataType = Console.ReadLine();

        
        string value1 = Console.ReadLine();

        
        string value2 = Console.ReadLine();

        object result = CompareValues(dataType, value1, value2);
        Console.WriteLine(result);
    }

    static object CompareValues(string dataType, string value1, string value2)
    {
        switch (dataType.ToLower())
        {
            case "int":
                int int1 = int.Parse(value1);
                int int2 = int.Parse(value2);
                return Math.Max(int1, int2);
            case "char":
                char char1 = char.Parse(value1);
                char char2 = char.Parse(value2);
                return (char1 > char2) ? char1 : char2;
            case "string":
                return (string.Compare(value1, value2) > 0) ? value1 : value2;
            default:
                throw new ArgumentException("Invalid data type entered.");
        }
    }
}
