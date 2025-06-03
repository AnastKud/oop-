using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    /// <summary>
    /// для сортировки кругов по длине окружности (периметру) в порядке убывания
    /// </summary>
    internal class CircleCompare : IComparer<Circle>
    {
        public int Compare(Circle a, Circle b)
        {
            return b.GetCircumference().CompareTo(a.GetCircumference());
        }
    }
}
