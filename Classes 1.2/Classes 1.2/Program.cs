using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_1._2
{
    class Program
    {
        class Rectangle
        {
            private double side1, side2;

            public Rectangle(double side1, double side2)
            {
                this.side1 = side1;
                this.side2 = side2;
            }

            private double AreaCalculator()
            {
                return side1 * side2;
            }

            private double PerimetrCalculator()
            {
                return 2 * (side1 + side2);
            }

            public double Area
            {
                get
                {
                    return AreaCalculator();
                }
            }

            public double Perimetr
            {
                get
                {
                    return PerimetrCalculator();
                }
            }
        }

        static void Main(string[] args)
        {
            double side1, side2;

            Console.Write("Put side 1: ");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Put side 2: ");
            side2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine("Area: {0}\nPerimetr: {1}", rectangle.Area, rectangle.Perimetr);
        }
    }
}
