using System.ComponentModel.Design;
using System.Drawing;

namespace AreaOfFigures
{
    internal class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double area = 0.00;

            if (type == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
                Console.WriteLine($"{area:f2}");
            }
            else if (type == "rectangle") 
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
                Console.WriteLine($"{area:f2}");
            }
            else if (type == "circle")
            { 
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"{area:f2}");
            }
            else
                Console.WriteLine("Invalid figure.");



        }
    }
}