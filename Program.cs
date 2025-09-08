Console.Clear();

int examAssignments = 5;

// single collection of students as tuples (Name, Scores). Add a new entry to extend.
var students = new (string Name, int[] Scores)[]
{
    ("Sophia", new int[] { 90, 86, 87, 98, 100, 94, 90 }),
    ("Andrew", new int[] { 92, 89, 81, 96, 90, 89 }),
    ("Emma", new int[] { 90, 85, 87, 98, 68, 89, 89, 89 }),
    ("Logan", new int[] { 90, 95, 87, 88, 96, 96 }),
    ("Pepe", new int[] { 67, 55, 99, 23, 78, 79, 15, 99, 99 })
};
string currentStudentLetterGrade = "";

// display the header row for the updated score report
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (var student in students)
{
    string currentStudent = student.Name;
    int[] studentScores = student.Scores;

    int sumExamScores = 0;
    int sumExtraScores = 0;
    int gradedAssignments = 0;
    int extraCount = 0;

    // the inner foreach loop separates exam scores and extra credit scores
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            sumExamScores += score;
        else
        {
            sumExtraScores += score;
            extraCount += 1;
        }
    }

    // exam average (one decimal in output)
    decimal examScore = (decimal)sumExamScores / examAssignments;

    // extra credit contribution: 10% of the sum of extra credit scores, spread over the number of exams
    decimal extraCreditPoints = 0m;
    int extraCreditDisplay = 0;
    if (extraCount > 0)
    {
        extraCreditPoints = ((decimal)sumExtraScores * 0.1m) / examAssignments;
        extraCreditDisplay = (int)Math.Round((decimal)sumExtraScores / extraCount);
    }

    // overall grade: (sumExamScores + 10% of sumExtraScores) / numberOfExams
    decimal overallGrade = ((decimal)sumExamScores + ((decimal)sumExtraScores * 0.1m)) / examAssignments;

    // determine letter grade based on overall grade
    if (overallGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (overallGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (overallGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (overallGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (overallGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (overallGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (overallGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (overallGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (overallGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (overallGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (overallGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (overallGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";


    Console.WriteLine($"{currentStudent}\t\t{examScore:F1}\t\t{overallGrade:F2}\t{currentStudentLetterGrade}\t\t{extraCreditDisplay} ({extraCreditPoints:F2} pts)");
}

Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
