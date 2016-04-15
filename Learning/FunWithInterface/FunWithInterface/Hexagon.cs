using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterface
{
    class Hexagon : Shape, IPointy, IDraw3D
    {
        public int Points {
            get
            {
                return 6;
            }
            set
            {
            }
        }

        public Hexagon():base("Hexagon") { }

        public void Draw3D()
        {
            Console.WriteLine("Draw hexagon in 3D space.");
        }
    }
}
