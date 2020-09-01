using System;
using static System.Console;

namespace Class_Object
{
    class Shapes
    {
        public double length;
        public double width;
        public double radius;

        public double CalArea(double l, double w)
        {
            length = l;
            width = w;
            double Area = w * l;
            return Area;
        }
        //Challenge
        public double CalCircleArea(double r)
        {
            radius = r;
            double CircleArea = 3.15 * (r * r);
            CircleArea = Math.Round(CircleArea, 2);
            return CircleArea;
        }
    }
    class Program
    {
        static void Main()
        {
            double RecWidth = 7;
            double RecLength = 8;
            double SqWidth = 2;
            double CirRadius = 3;

            Shapes Rectangle = new Shapes();
            Shapes Square = new Shapes();
            Shapes Circle = new Shapes();

            WriteLine("Area of Rectangle is: " + Rectangle.CalArea(RecLength, RecWidth));

            WriteLine("Area of Square is: " + Square.CalArea(SqWidth, SqWidth));

            WriteLine("Area of Circle is: " + Circle.CalCircleArea(CirRadius));
        }
    }
}
