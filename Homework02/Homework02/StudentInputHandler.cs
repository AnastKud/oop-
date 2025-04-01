class StudentInputHandler
{
    public static Student[] GetStudents(int n)
    {
        Student[] students = new Student[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter student's last name: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter group number: ");
            string group = Console.ReadLine();
            Console.WriteLine("Enter student grades: ");
            int[] grades = Console.ReadLine().Split().Select(int.Parse).ToArray();
            students[i] = new Student(surname, group, grades);
        }
        return students;
    }
}