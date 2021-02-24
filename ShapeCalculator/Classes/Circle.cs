using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Classes
{
    class Circle
    {
        public static double GetArea(double radius)
        {
            return (Math.PI * Math.Pow(radius, 2));
        }

        public static double GetPerimeter(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}
