using System;

class Program
{
    static void Main()
    {
        
        string product = Console.ReadLine().ToLower();
        int quantity = int.Parse(Console.ReadLine());

        CalculateTotalPrice(product, quantity);
    }

    static void CalculateTotalPrice(string product, int quantity)
    {
        double pricePerItem = 0.0;
        switch (product)
        {
            case "coffee":
                pricePerItem = 1.50;
                break;
            case "water":
                pricePerItem = 1.00;
                break;
            case "coke":
                pricePerItem = 1.40;
                break;
            case "snacks":
                pricePerItem = 2.00;
                break;
            default:
                Console.WriteLine("Invalid product entered.");
                return;
        }

        double totalPrice = pricePerItem * quantity;
        Console.WriteLine($"{totalPrice:F2}");
    }
}
