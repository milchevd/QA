static int CalcRectArea(int width, int lenght) 
{
    return width * lenght;
}

int width = int.Parse(Console.ReadLine());
int lenght = int.Parse(Console.ReadLine());

int area = CalcRectArea(width, lenght);
Console.WriteLine(area);

