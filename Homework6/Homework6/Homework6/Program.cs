using Homework6;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
/// <summary>
/// Главный класс программы
/// </summary>
class Program
{
    static void Main()
    {
        string filePath = "figures.txt";
        var figures = new List<GeometricFigure>();
        var circles = new List<Circle>();
        var squares = new List<Square>();

        foreach (var line in File.ReadAllLines(filePath))
        {
            var parts = line.Split(' ');

            if (parts.Length == 4)
            {
                double x = double.Parse(parts[0]);
                double y = double.Parse(parts[1]);
                double r = double.Parse(parts[2]);
                string color = parts[3];

                var circle = new Circle(x, y, r, color);
                figures.Add(circle);
                circles.Add(circle);
            }
            else if (parts.Length == 8)
            {
                var vertices = new (double X, double Y)[4];
                for (int i = 0; i < 4; i++)
                {
                    vertices[i] = (double.Parse(parts[i * 2]), double.Parse(parts[i * 2 + 1]));
                }

                var square = new Square(vertices);
                figures.Add(square);
                squares.Add(square);
            }
        }

        Console.WriteLine("Nr. | Type | Area");
        for (int i = 0; i < figures.Count; i++)
        {
            var type = figures[i] is Circle ? "Circle" : "Square";
            Console.WriteLine($"{i + 1,5} | {type,-11} | {figures[i].Area:F2}");
        }

        figures.Sort(new AreaComparer());
        Console.WriteLine("\nSorted by Area:");
        foreach (var f in figures)
            Console.WriteLine(f.GetInfo());

        Console.WriteLine("\nPerimeters of squares in first quadrant:");
        foreach (var sq in squares.Where(s => s.IsInFirstQuadrant()))
            Console.WriteLine(sq.GetPerimeter());

        circles.Sort(new CircleCompare());
        Console.WriteLine("\nCircle circumferences (descending):");
        foreach (var c in circles)
            Console.WriteLine($"{c.GetCircumference():F2} ({c.Color})");
        Console.ReadLine();
    }
}
