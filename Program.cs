using Paint.Colors;
using Paint.Shapes;
using System;

namespace Paint
{
    internal class Program
    {
        private static void Main()
        {
            new Line(10, new Red()).Draw();
            new Arrow(10, new Green()).Draw();
            new Rectangle(10, 6, new Blue()).Draw();
            new Square(10, new Green()).Draw();

            Console.ReadLine();
        }
    }
}
