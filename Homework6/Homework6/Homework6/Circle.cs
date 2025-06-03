using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    /// <summary>
    /// Класс окружности, реализующий интерфейс геометрической фигуры
    /// </summary>
    internal class Circle : GeometricFigure
    {
        private double x, y, radius;
        private string color;
        /// <summary>
        /// Конструктор класса Circle
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radius"></param>
        /// <param name="color"></param>
        public Circle(double x, double y, double radius, string color)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.color = color;
        }
        /// <summary>
        /// Свойство площади круга
        /// </summary>
        public double Area => Math.PI * radius * radius;
        /// <summary>
        /// Индексатор для доступа к координатам и радиусу круга
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public double this[int index]
        {
            get
            {
                if (index == 0) return x;
                if (index == 1) return y;
                if (index == 2) return radius;
                throw new IndexOutOfRangeException();
            }
        }
        public string Color => color;
        /// <summary>
        /// Метод для получения длины окружности круга
        /// </summary>
        /// <returns></returns>
        public double GetCircumference() => 2 * Math.PI * radius;
        /// <summary>
        /// Метод для получения информации о круге
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return $"Circle:({color}):area = {Area:F2}, circumference = {GetCircumference():F2}";
        }
    }
}
