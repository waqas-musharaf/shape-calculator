using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Classes
{
    class Square
    {
        public static double GetArea(double length)
        {
            return Math.Pow(length, 2);
        }

        public static double GetPerimeter(double length)
        {
            return length * 4;
        }
    }
}
