using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// Базовый тип геометрической фигуры
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public abstract float GetSquare();
    }
}
