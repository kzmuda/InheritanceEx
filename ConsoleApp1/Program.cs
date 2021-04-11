using System;
using Inheritance;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LineSegment linesegment = new LineSegment(0, 0, 1, 1);

            Console.WriteLine(linesegment.CalculateLength());
        }
    }
}
