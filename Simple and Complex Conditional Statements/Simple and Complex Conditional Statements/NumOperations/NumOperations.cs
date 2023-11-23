namespace NumOperations
{
    internal class NumOperations
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            double result = 0.00;
            
            switch (op)
            {
                case "+":
                    result = num1 + num2;                  
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                
            }
            Console.WriteLine($"{num1} {op} {num2} = {result:F2}");
        }
    }
}