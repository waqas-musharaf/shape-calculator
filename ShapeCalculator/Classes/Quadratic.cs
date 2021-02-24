using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Classes
{
    class Quadratic
    {
        public static Tuple<string, string> Solve(double a, double b, double c)
        {
            // Discriminant of quadratic formula
            double discriminant = b * b - 4 * a * c;

            // Hold results
            double x, x1, x2, img;
            Tuple<string, string> output;

            // If discriminant > 0 -> 2 real solutions
            if (discriminant > 0)
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                output = new Tuple<string, string>
                    ("2 real solutions", "(" + x2 + ", " + x1 + ")");
            }
            // If discriminant < 0 -> 2 imaginary solutions
            else if (discriminant < 0)
            {
                discriminant = -discriminant;
                x = -b / (2 * a);
                img = Math.Sqrt(discriminant) / (2 * a);

                output = new Tuple<string, string>
                    ("2 imaginary solutions", "(" + img + ", " + x + ")");
            }
            // If discriminant = 0 -> 1 real solution
            else
            {
                x = (-b + Math.Sqrt(discriminant)) / (2 * a);

                output = new Tuple<string, string>
                    ("1 real solution", "(" + x + ")");
            }

            return output;
        }
    }
}
