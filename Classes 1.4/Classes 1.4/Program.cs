using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_1._4
{
    class Program
    {
        class Point
        {
            private int x = 0, y = 0;
            private string name;

            public Point(int x, int y, string name)
            {
                this.x = x;
                this.y = y;
                this.name = name;
            }

            public int X
            {
                get
                {
                    return x;
                }
            }

            public int Y
            {
                get
                {
                    return y;
                }
            }

            public string Name
            {
                get
                {
                    return name;
                }
            }

        }

        class Figure
        {
            Point A, B, C, D, E;
            private string name;
            bool triangleTrue = false;
            bool rectangleTrue = false;
            bool pentagonTrue = false;

            public Figure(Point A, Point B, Point C)
            {
                this.A = A;
                this.B = B;
                this.C = C;

                triangleTrue = true;
                name = "Triangle";
            }

            public Figure(Point A, Point B, Point C, Point D)
            {
                this.A = A;
                this.B = B;
                this.C = C;
                this.D = D;

                rectangleTrue = true;
                name = "Rectangle";
            }

            public Figure(Point A, Point B, Point C, Point D, Point E)
            {
                this.A = A;
                this.B = B;
                this.C = C;
                this.D = D;
                this.E = E;

                pentagonTrue = true;
                name = "Pentagon";
            }

            private double LenghtSide(Point A, Point B)
            {
               return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            }

            public void PerimetrCalculator()
            {
                double perimetr = 0;

                if (pentagonTrue == true)
                {
                    double side1 = LenghtSide(A, B);
                    double side2 = LenghtSide(B, C);
                    double side3 = LenghtSide(C, D);
                    double side4 = LenghtSide(D, E);
                    double side5 = LenghtSide(E, A);

                    perimetr = side1 + side2 + side3 + side4 + side5;
                }
                if(rectangleTrue == true)
                {
                    double side1 = LenghtSide(A, B);
                    double side2 = LenghtSide(B, C);
                    double side3 = LenghtSide(C, D);
                    double side4 = LenghtSide(D, A);

                    perimetr = side1 + side2 + side3 + side4;
                }
                if(triangleTrue == true)
                {
                    double side1 = LenghtSide(A, B);
                    double side2 = LenghtSide(B, C);
                    double side3 = LenghtSide(C, A);

                    perimetr = side1 + side2 + side3;
                }

                Console.WriteLine("Name: {0}\nPerimetr = {1}", name, perimetr);
            }
        }
        static void Main(string[] args)
        {
            Point A = new Point(12, 5, "A");
            Point B = new Point(1, 3, "B");
            Point C = new Point(40, 25, "C");
            Point D = new Point(1, 2, "D");

            Figure figure = new Figure(A, B, C, D);

            figure.PerimetrCalculator();
        }
    }
}
