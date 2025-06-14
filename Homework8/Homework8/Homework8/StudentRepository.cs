using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    /// <summary>
    /// Класс, отвечающий за загрузку и хранение студентов из файла
    /// </summary>
    public class StudentRepository
    {
        private readonly string _filePath;
        private readonly List<Student> _students;

        public StudentRepository(string filePath)
        {
            _filePath = filePath;
            _students = new List<Student>();
        }

        /// <summary>
        /// Загрузка студентов из файла
        /// </summary>
        public void Load()
        {
            foreach (string line in File.ReadLines(_filePath))
            {
                var parts = line.Split(',');
                var student = new Student
                {
                    LastName = parts[0],
                    Grades = parts[1].Split(' ')
                    .Select(int.Parse)
                    .ToList(),
                    Faculty = parts[2],
                    Dean = parts[3],
                    Stipend = int.Parse(parts[4])
                };
                _students.Add(student);
            }
        }

        /// <summary>
        /// Получение списка студентов
        /// </summary>
        public List<Student> GetStudents()
        {
            return _students;
        }

        /// <summary>
        /// Вывод студентов, отсортированных по факультету
        /// </summary>
        public void PrintAll()
        {
            var sorted = _students.OrderBy(s => s.Faculty);
            Console.WriteLine("Last Name  Grades     Faculty    Dean    Scholarship");
            foreach (var student in sorted)
            {
                student.PrintInfo();
            }
        }
    }
}
