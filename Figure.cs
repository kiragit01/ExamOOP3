using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP3
{
    class Figure
    {
        Point A, B, C, D, E;
        private string name;
        public Figure(Point A, Point B, Point C) : this(A, B, C, C) { name = "Треугольник"; }
        public Figure(Point A, Point B, Point C, Point D) : this(A, B, C, D, D) { name = "Четырехугольник"; }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
            name = "Пятиугольник";
        }

        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }

        public void PerimeterCalculator()
        {
            Console.WriteLine($"Фигура - {name}");
            Console.WriteLine($"Площадь: {(LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E) + LengthSide(E, A)):f2}");
        }
    }
}
