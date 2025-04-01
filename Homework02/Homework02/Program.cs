class Program
{
    static void Main()
    {
        int n;
        while (true)
        {
            Console.WriteLine("Enter the number of students: ");
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                break;
            Console.WriteLine("Error! Please enter a valid positive number.");
        }

        Student[] students = StudentInputHandler.GetStudents(n);

        StudentProcessor.DisplayStudents(students);
        StudentProcessor.DisplayExcellentStudents(students);

        Console.WriteLine("Enter group number: ");
        string groupNumber = Console.ReadLine();
        StudentProcessor.DisplayBadStudentsByGroup(students, groupNumber);
    }
}
