using System;
using System.Linq;
using System.Collections.Generic;

class Student
{
    private string surname;
    private string group;
    private int[] grades;

    public Student(string surname, string group, int[] grades)
    {
        this.surname = surname;
        this.group = group;
        this.grades = grades;
    }

    public string Surname => surname;
    public string Group => group;
    public double AverageGrade => grades.Average();

    public int this[int index]
    {
        get { return grades[index]; }
        set { grades[index] = value; }
    }

    public int CountTen => grades.Count(x => x == 10);
    public bool IsBadStudent => grades.Any(x => x < 4);
}