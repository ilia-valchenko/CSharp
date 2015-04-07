using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dichotomy
{
    class Start
    {
        static double Function(double x)
        {
            return 4 - System.Math.Exp(x) - 2*x*x;
            //return x * Math.Sin(x);
        }

        static void Main(string[] args)
        {
            double a = 0, b = 1;
            double epsilon = 1e-2;

                try
                {
                    Console.Write("Введите начало отрезка: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите конец отрезка: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите точность вычисления: ");
                    epsilon = Convert.ToDouble(Console.ReadLine());
                }
                catch (System.FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\nSYSTEM FORMAT EXCEPTION: ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.StackTrace);
                    Console.ResetColor();
                }

            ISolver[] arr = new ISolver[] {new DichotomySolver(),new GoldenSolver()};

            Console.WriteLine("\nРЕЗУЛЬТАТ методом дихотомии: " + arr[0].Solve(Function, a, b, epsilon));
            Console.WriteLine("РЕЗУЛЬТАТ методом золотого сечения: " + arr[1].Solve(Function, a, b, epsilon));

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\nНажмите для продолжения...");
            Console.ReadKey(true);
        }
    }
}
