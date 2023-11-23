int countOfStudents = int.Parse(Console.ReadLine());
double totalGrades = 0;

for (int i = 0; i < countOfStudents; i++)
{
    double grade = double.Parse(Console.ReadLine());
    totalGrades += grade;
}

double averageGrade = totalGrades / countOfStudents;
Console.WriteLine($"{averageGrade:F2}");