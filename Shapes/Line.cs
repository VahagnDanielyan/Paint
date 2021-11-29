using Paint.Colors;
using System;

namespace Paint.Shapes
{
    public class Line : Shape
    {
        private int Length { get; init; }

        public Line(int length, IColorable color)
        {
            color.SetColor();
            Length = length;
        }

        public override void Draw()
        {
            Console.WriteLine($"{new string('*', Length)}");
        }
    }
}
