using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    /// <summary>
    /// Интерфейс для геометрических фигур.
    /// </summary>
    interface GeometricFigure
    {
        double Area { get; }
        string GetInfo();
        double this[int index] { get;}
    }
}
