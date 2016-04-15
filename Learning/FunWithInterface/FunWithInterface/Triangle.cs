using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterface
{
    class Triangle : Shape
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public Triangle():base("Triangle") { }
        public Triangle(int a, int b, int c):base("Triangle")
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
