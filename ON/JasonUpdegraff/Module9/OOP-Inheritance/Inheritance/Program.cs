using System;
using static System.Console;

namespace Inheritance
{
    class Program
    {
        class Shapes
        {
            public double length;
            public double width;
            public double radius;

            public void DispBase()
            {
                WriteLine("Base length is " + length);
                WriteLine("Base width is " + width);
                WriteLine("Base radius is " + radius);
                WriteLine("\n");
            }
        }
        class Rectangle : Shapes
        {
            public void CalArea(double l, double w)
            {
                length = l;
                width = w;
                double RecArea = l * w;
                WriteLine("Rectangle length is: " + length);
                WriteLine("Rectangle width is: " + width);
                WriteLine("Rectangle Area is: " + RecArea);
            }
        }
        class Square : Shapes
        {
            public void CalArea(double a)
            {
                length = a;
                double SqArea = a * a;
                WriteLine("Square side length is: " + a);
                WriteLine("Square Area is: " + SqArea);
            }
        }
        class Circle : Shapes
        {
            public void CalArea(double r)
            {
                radius = r;
                double CirArea = 3.15 * r;
                WriteLine("Circle radius is: " + radius);
                WriteLine("Circle Area is: " + CirArea);
            }
        }
        static void Main()
        {
            Rectangle MyRec = new Rectangle();

            Circle MyCir = new Circle();

            Square MySq = new Square();

            MyRec.CalArea(3, 4);
            MyRec.DispBase();

            MySq.CalArea(10);
            MySq.DispBase();

            MyCir.CalArea(8);
            MyCir.DispBase();

            
        }
    }
}
