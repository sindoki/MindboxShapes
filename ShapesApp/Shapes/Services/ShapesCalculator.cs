using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// Базовая реализация расчетов над фигурами
    /// </summary>
    public class ShapesCalculator : IShapesCalculator
    {
        public float CalculateShapeSquare(Shape shape)
        {
            return shape.GetSquare();
        }
    }
}
