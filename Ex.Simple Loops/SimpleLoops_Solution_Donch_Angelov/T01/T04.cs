namespace E05;
class T04
{
    static void Main_(string[] args)
    {
        int maxPoorGrades = int.Parse(Console.ReadLine());

        int numberPoorGrades = 0;
        double gradesTotal = 0;
        int gradesNum = 0;
        string lastProblem = "";

        while(numberPoorGrades < maxPoorGrades)
        {
            String curProblem = Console.ReadLine();

            if (curProblem == "Enough")
                break; // the exam is over

            lastProblem = curProblem;
            int curGrade = int.Parse(Console.ReadLine());

            gradesTotal += curGrade; // accumulate his total score
            gradesNum++;

            if (curGrade <= 4) // if the grade is low,
                numberPoorGrades++; // increase the number of sequential poor grades
        }

        if (numberPoorGrades >= maxPoorGrades)
        {
            // too many sequential poor grades
            Console.WriteLine($"You need a break, {numberPoorGrades} poor grades.");
        } else
        {
            // succeeded!
            Console.WriteLine($"Average score: {gradesTotal/gradesNum:f2}");
            Console.WriteLine($"Number of problems: {gradesNum}");
            Console.WriteLine($"Last problem: {lastProblem}");
        }
    }
}
