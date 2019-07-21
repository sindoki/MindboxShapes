using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Shape
    {
        public float SideA { get; private set; }

        public float SideB { get; private set; }

        public float SideC { get; private set; }

        public Triangle(float sideA, float sideB, float sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override float GetSquare()
        {
            // Вычисляем площадь треугольника по формуле Герона
            float p = (SideA + SideB + SideC) / 2;

            return (float)Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightAngled() {
            //Проверяем по теореме Пифагора

            float largeSide, 
                  smallSide1, 
                  smallSide2;

            if (SideA >= SideB && SideA >= SideC)
            {
                largeSide = SideA;
                smallSide1 = SideB;
                smallSide2 = SideC;
            }
            else if (SideB >= SideA && SideB >= SideC)
            {
                largeSide = SideB;
                smallSide1 = SideC;
                smallSide2 = SideA;
            }
            else
            {
                largeSide = SideC;
                smallSide1 = SideA;
                smallSide2 = SideB;
            }

            return (largeSide * largeSide == smallSide1 * smallSide1 + smallSide2 * smallSide2);
        }

    }
}
