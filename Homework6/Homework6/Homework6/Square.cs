using Homework6;
using System;
using System.Linq;
/// <summary>
/// Класс квадрата, реализующий интерфейс геометрической фигуры
/// </summary>
public class Square : GeometricFigure
{
    private (double X, double Y)[] vertices;
    /// <summary>
    /// Конструктор с вершинами
    /// </summary>
    /// <param name="vertices"></param>
    public Square((double X, double Y)[] vertices)
    {
        this.vertices = vertices;
    }
    /// <summary>
    /// Свойство для получения площади квадрата
    /// </summary>
    public double Area
    {
        get
        {
            double side = GetDistance(vertices[0], vertices[1]);
            return side * side;
        }
    }
    /// <summary>
    /// Метод для получения информации о квадрате
    /// </summary>
    /// <returns></returns>
    public string GetInfo()
    {
        return $"Square: area = {Area:F2}";
    }
    /// <summary>
    /// Индексатор для доступа к координатам вершин квадрата
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public double this[int index] => vertices[index].X;
    private double GetDistance((double X, double Y) a, (double X, double Y) b)
    {
        return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
    }
    /// <summary>
    /// Метод для получения периметра квадрата
    /// </summary>
    /// <returns></returns>
    public double GetPerimeter()
    {
        double side = GetDistance(vertices[0], vertices[1]);
        return side * 4;
    }
    /// <summary>
    /// Метод проверки — находится ли квадрат в первой координатной четверти
    /// </summary>
    /// <returns></returns>
    public bool IsInFirstQuadrant()
    {
        return vertices.All(v => v.X > 0 && v.Y > 0);
    }
}
