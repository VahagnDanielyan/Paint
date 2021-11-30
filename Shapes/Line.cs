using Paint.Colors;
using System;

namespace Paint.Shapes
{
    internal class Line : Shape
    {
        public Line(IColorable _color)
        {
            Console.ForegroundColor = _color.Color;
            Length = 10;
        }

        public virtual int Length { get; set; }

        public override void Draw()
        {
            Console.WriteLine($"{new string('*', Length)}");
        }
    }
}
