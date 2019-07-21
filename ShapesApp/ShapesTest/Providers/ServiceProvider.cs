using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesTest
{
    /// <summary>
    /// Класс для получения экземпляров служб для тестирования
    /// </summary>
    public class ServiceProvider
    {
        public static IShapesCalculator GetShapesCalculator()
        {
            return new ShapesCalculator();
        }
    }
}
