using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP3
{
    class Program
    {
        static void Main()
        {
            Point a = new Point(1, 1, "a");
            Point b = new Point(3, 2, "b");
            Point c = new Point(3, 4, "c");
            Point d = new Point(6, 2, "d");
            Point e = new Point(5, 5, "e");

            Figure figure1 = new Figure(a, b, c);
            Figure figure2 = new Figure(a, b, c, d);
            Figure figure3 = new Figure(a, b, c, d, e);

            figure1.PerimeterCalculator();
            figure2.PerimeterCalculator();
            figure3.PerimeterCalculator();

            Console.ReadKey();
        }

    }
}
