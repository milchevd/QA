int number = int.Parse(Console.ReadLine());

// дефиниране на масив с дните от седмицата
string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

// проверка дали числото е в границите [1 , 7]
if (number >= 1 && number <= 7)
{    
    Console.WriteLine(daysOfWeek[number - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}