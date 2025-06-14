using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    /// <summary>
    /// Репозиторий для загрузки и работы со студентами.
    /// </summary>
    public class StudentRepository
    {
        private readonly string _filePath;
        private readonly List<Students> _students;
        private bool _ascending = true;

        public StudentRepository(string filePath)
        {
            _filePath = filePath;
            _students = new List<Students>();
        }

        /// <summary>
        /// Загрузка студентов из файла.
        /// </summary>
        public void Load()
        {
            foreach (var line in File.ReadLines(_filePath))
            {
                var parts = line.Split(',');
                var student = new Students
                {
                    LastName = parts[0],
                    Grades = parts[1].Split(' ').Select(int.Parse).ToList(),
                    Faculty = parts[2],
                    Dean = parts[3],
                    Stipend = int.Parse(parts[4])
                };
                _students.Add(student);
            }
        }

        public List<Students> GetStudents() => _students;

        /// <summary>
        /// Переключение порядка сортировки.
        /// </summary>
        public void ToggleSortOrder() => _ascending = !_ascending;

        /// <summary>
        /// Печать всей информации о студентах.
        /// </summary>
        public void PrintAll()
        {
            var sorted = _ascending ? _students.OrderBy(s => s.Faculty) : _students.OrderByDescending(s => s.Faculty);
            Console.WriteLine("\nLast Name  Grades     Faculty    Dean    Scholarship");
            foreach (var student in sorted)
                student.PrintInfo();

            Console.WriteLine($"\nNumber of students: {_students.Count}");
            Console.WriteLine($"Average score: {_students.Average(s => s.GetAverageGrade()):F2}\n");
        }

        /// <summary>
        /// Печать студентов, у которых есть оценки ниже указанной.
        /// </summary>
        public void PrintStudentsBelowGrade(int grade)
        {
            var filtered = _students.Where(s => s.Grades.Any(g => g < grade));
            foreach (var student in filtered)
                student.PrintInfo();
        }

        /// <summary>
        /// Печать студентов с указанного факультета.
        /// </summary>
        public void PrintStudentsFromFaculty(string faculty)
        {
            var filtered = _students.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase));
            foreach (var student in filtered)
                student.PrintInfo();
        }
    }
}
