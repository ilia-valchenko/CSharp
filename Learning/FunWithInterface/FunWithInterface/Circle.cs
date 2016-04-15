using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterface
{
    class Circle : Shape, IPointy, IDraw3D
    {
        public int Radius { get; set; }
        public int Points {
            get
            {
                return 0;
            }
            set
            {
            }
        }

        public Circle():base("Circle") { }
        public Circle(int radius):base("Circle")
        {
            Radius = radius;
        }

        public void Draw3D()
        {
            Console.WriteLine("Draw circle in 3D space.");
        }
    }
}
