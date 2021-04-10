using System;
using System.Collections.Generic;

namespace Painter
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(2);
            Circle c2 = new Circle(5);
            Square s1 = new Square(3);
            Square s2 = new Square(6);

            List<Shape> list = new List<Shape>();
            list.Add(c1);
            list.Add(c2);
            list.Add(s1);
            list.Add(s2);
            decimal sum = 0;
            foreach(Shape item in list)
            {
                sum += item.Area();
            }
            Console.WriteLine(sum);
        }
    }
}
