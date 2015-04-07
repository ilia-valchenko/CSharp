using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dichotomy
{
    class GoldenSolver:ISolver
    {
        public double Solve(Func<double, double> fun, double a, double b, double epsilon)
        {
            if ((b - a) < epsilon)
                return (a + b) / 2;

            double phi = (1 + Math.Sqrt(5)) / 2; // золотой коэффициент

            double x1 = b - (b - a) / phi;
            double x2 = a + (b - a) / phi;

            if (fun(x1) < fun(x2))
            {
                return Solve(fun, a, x2, epsilon);
            }
            else
            {
                return Solve(fun, x1, b, epsilon);
            }
        }
    }
}
