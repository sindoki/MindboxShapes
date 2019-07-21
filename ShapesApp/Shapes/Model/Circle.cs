using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Shape
    {
        public float Radius { get; private set; }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public override float GetSquare()
        {
            return (float)(Math.PI * Radius * Radius);
        }
    }
}
