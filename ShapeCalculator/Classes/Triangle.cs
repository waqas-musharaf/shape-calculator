using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Classes
{
    class Triangle
    {
        public static double GetArea(double a, double b, double c)
        {
            double p = GetPerimeter(a, b, c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static double GetPerimeter(double a, double b, double c)
        {
            return a + b + c;
        }
    }
}
