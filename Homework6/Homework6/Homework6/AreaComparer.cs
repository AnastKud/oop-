using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    /// <summary>
    /// Класс для сравнения геометрических фигур по площади.
    /// </summary>
    internal class AreaComparer : IComparer<GeometricFigure>
    {
        public int Compare(GeometricFigure a, GeometricFigure b)
        {
            return a.Area.CompareTo(b.Area);
        }
    }
}
