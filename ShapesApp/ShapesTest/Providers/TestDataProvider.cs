using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesTest
{
    public class TestDataProvider
    {
        public static Tuple<Shape, float>[] ShapesAndSquares =
        {
            new Tuple<Shape, float>(new Circle(2), (float)(4 * Math.PI)),
            new Tuple<Shape, float>(new Circle(0), 0),
            new Tuple<Shape, float>(new Circle(3.5f), (float)(12.25 * Math.PI)),
            new Tuple<Shape, float>(new Triangle(3, 4, 5), 6),
            new Tuple<Shape, float>(new Triangle(5, 7, 10), (float)Math.Sqrt(264))
        };
    }
}
