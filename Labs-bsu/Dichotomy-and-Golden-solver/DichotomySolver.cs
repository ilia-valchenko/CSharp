using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dichotomy
{
    class DichotomySolver:ISolver
    {
        public double Solve(Func<double, double> fun, double a, double b, double epsilon)
        {
            if ((b - a) < epsilon)
                return (a + b) / 2;

            double x1 = ((a + b) / 2) - ((b - a) / 4);
            double x2 = ((a + b) / 2) + ((b - a) / 4);

            if (fun(x1) < fun(x2))
            {
                return Solve(fun, a, (a + b) / 2, epsilon);
            }
            else
            {
                return Solve(fun, (a + b) / 2, b, epsilon);
            }
        }
    }
}
