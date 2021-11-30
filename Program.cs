using Paint.Colors;
using Paint.Shapes;
using System;

namespace Paint
{
    internal class Program
    {
        private static void Main()
        {
            Line line = new(new Red()) { Length = 15 };
            Arrow arrow = new(new Green()) { Length = 18 };
            Rectangle rectangle = new(new Blue()) { SizeX = 10, SizeY = 12 };
            Square square = new(new Green()) { SizeX = 15 };

            Paint(line);
            Paint(arrow);
            Paint(rectangle);
            Paint(square);

            Console.ReadLine();
        }

        public static void Paint(IDrawable drawable)
        {
            drawable.Draw();
        }
    }
}
