using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// Интерфейс для расчетов над фигурами
    /// </summary>
    public interface IShapesCalculator
    {
        /// <summary>
        /// Расчет площади фигуры
        /// </summary>
        float CalculateShapeSquare(Shape shape);
    }
}
