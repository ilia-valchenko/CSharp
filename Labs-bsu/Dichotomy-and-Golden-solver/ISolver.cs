using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dichotomy
{
    interface ISolver
    {
        double Solve(Func<double, double> f, double a, double b, double epsilon);
    }
}
