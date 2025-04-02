class StudentProcessor
{
    public void DisplayStudents(Student[] students)
    {
        Console.WriteLine("List of students in alphabetical order with their GPA: ");
        foreach (var student in students.OrderBy(x => x.Surname))
        {
            Console.WriteLine($"{student.Surname} (Group {student.Group}) - Average score: {student.AverageGrade:F2}");
        }
    }

    public void DisplayExcellentStudents(Student[] students)
    {
        int countExselentStudents = students.Count(x => x.CountTen >= 2);
        Console.WriteLine($"Number of excellent students: {countExselentStudents}");
    }

    public void DisplayBadStudentsByGroup(Student[] students, string groupNumber)
    {
        var badStudents = students.Where(x => x.Group == groupNumber && x.IsBadStudent).ToList();
        if (badStudents.Any())
        {
            Console.WriteLine("List of failing students in the group " + groupNumber + ":");
            foreach (var student in badStudents)
            {
                Console.WriteLine(student.Surname);
            }
        }
        else
        {
            Console.WriteLine("Everyone in the group is great (there are no losers)!");
        }
    }
}