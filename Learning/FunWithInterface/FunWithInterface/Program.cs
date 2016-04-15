using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Hexagon h = new Hexagon();
            Triangle t = new Triangle();
            IPointy inter = null;
            Shape[] figures = {t, h, c};

            Console.WriteLine("What is the figure #1: {0}\nNumber of vertex: {1}\n", c.Name, c.Points);
            Console.WriteLine("What is the figure #2: {0}\nNumber of vertex: {1}", h.Name, h.Points);

            //object obj = (IPointy)t;
            try
            {
                inter = (IPointy)t;
                Console.WriteLine("Points: {0}", inter.Points);
            } catch(InvalidCastException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            if ((h as IPointy) != null)
                Console.WriteLine("\nAll right! This type implements IPointy.\n");

            for(int i = 0; i < figures.Length; i++)
            {
                if (figures[i] is IPointy)
                    DrawIn3D((IDraw3D)figures[i]);
            }

            Console.WriteLine("\nA function which return IPointy. Result: {0}", FindFirstIPointyShape(figures));

            Console.WriteLine("\nTap to continue...");
            Console.ReadKey(true);
        }

        static void DrawIn3D(IDraw3D itf3D)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type.");
            itf3D.Draw3D();
        }

        static IPointy FindFirstIPointyShape(Shape[] arr)
        {
            foreach(Shape item in arr)
            {
                if (item is IPointy)
                    return (IPointy)item;
            }

            return null;
        }
    }
}
